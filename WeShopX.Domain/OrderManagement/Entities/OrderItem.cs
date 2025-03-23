using WeShopX.Domain.Common;
using WeShopX.Domain.OrderManagement.ValueObjects;
using WeShopX.Domain.ProductManagement.ValueObjects;

namespace WeShopX.Domain.OrderManagement.Entities
{
    /// <summary>
    /// Immutable – Cannot be changed after order confirmation.
    /// </summary>
    public class OrderItem : Entity<OrderItemId>
    {
        public ProductId ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal TotalPrice { get; private set; }

        public OrderItem(OrderItemId id, ProductId productId, int quantity, decimal unitPrice)
            : base(id)
        {
            if (quantity <= 0) throw new ArgumentException("Quantity must be greater than zero.");

            ProductId = productId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = quantity * unitPrice;  // Store total price at order time
        }
    }
}
