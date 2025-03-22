﻿namespace WeShopX.Domain.Common
{
    public abstract class AggregateRoot<TId> : Entity<TId> where TId : notnull
    {
        public DateTime CreateDate { get; private set; } = DateTime.Now;
        public DateTime UpdateDate { get; private set; } = DateTime.Now;
        protected AggregateRoot(TId id) : base(id)
        {
            CreateDate = DateTime.UtcNow;
            UpdateDate = DateTime.UtcNow;
        }

        public void UpdateAggregate() => UpdateDate = DateTime.Now;


    }
}
