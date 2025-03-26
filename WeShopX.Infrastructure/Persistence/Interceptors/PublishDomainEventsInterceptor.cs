﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using WeShopX.Domain.Common;

namespace WeShopX.Infrastructure.Persistence.Interceptors
{
    public class PublishDomainEventsInterceptor : SaveChangesInterceptor
    {
        private readonly IMediator _mediator;

        public PublishDomainEventsInterceptor(IMediator mediator)
        {
            _mediator = mediator;
        }

        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            PublishDomainEvents(eventData.Context).GetAwaiter().GetResult();
            return base.SavingChanges(eventData, result);
        }

        public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
        {
            await PublishDomainEvents(eventData.Context);
            return await base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        private async Task PublishDomainEvents(DbContext? dbContext)
        {

            if (dbContext is null)
            {
                return;
            }

            // Get hold of all the various entities.
            var entitiesWithDomainEvents = dbContext.ChangeTracker.Entries<IHasDomainEvents>()
                .Where(entry => entry.Entity.DomainEvents.Any())
                .Select(entry => entry.Entity)
                .ToList();

            // Get hold of all the various domain events.
            var domainEvents = entitiesWithDomainEvents.SelectMany(entry => entry.DomainEvents).ToList();

            // Publish domain events
            foreach (var domainEvent in domainEvents)
            {
                await _mediator.Publish(domainEvent);
            }
        }
    }
}
