namespace WeShopX.Domain.Common
{
    public abstract class Entity<TId> : IEquatable<TId> where TId : notnull
    {
        public TId Id { get; private set; }

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
