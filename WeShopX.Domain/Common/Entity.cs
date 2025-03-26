namespace WeShopX.Domain.Common
{
    public abstract class Entity<TId> : IEquatable<TId> where TId : notnull, IHasDomainEvents
    {
        public TId Id { get; private set; }

        private readonly List<IDomainEvent> _domainEvents = new();
        public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        protected Entity(TId id)
        {
            Id = id;
        }


        public bool Equals(TId? other)
        {
            return Equals((object?)other);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
