using WeShopX.Domain.Common;
using WeShopX.Domain.UserManagement.ValueObjects;

namespace WeShopX.Domain.UserManagement.Entities
{
    public class ShoppingCart : Entity<ShoppingCartId>, IHasDomainEvents
    {
        public ShoppingCart(ShoppingCartId id) : base(id)
        {
        }

        public UserId UserId { get; private set; } 
        private readonly List<CartItem> _items = new();
        public IReadOnlyList<CartItem> Items => _items.AsReadOnly();

        public ShoppingCart() : base(new ShoppingCartId(Guid.NewGuid())) { }
    }
}
