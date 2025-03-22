using WeShopX.Domain.Common;
using WeShopX.Domain.ProductManagement.ValueObjects;
using WeShopX.Domain.UserManagement.ValueObjects;

namespace WeShopX.Domain.UserManagement.Entities
{
    public class CartItem : Entity<CartItemId>
    {
        public ProductId ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal TotalPrice => Quantity * UnitPrice;

        public CartItem(CartItemId id, ProductId productId, int quantity, decimal unitPrice)
            : base(id)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");
            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}
