using WeShopX.Domain.Common;
using WeShopX.Domain.ProductManagement.ValueObjects;

namespace WeShopX.Domain.ProductManagement.Entities
{
    public class Stock : Entity<StockId>
    {
        public int Quantity { get; private set; }
        public ProductId ProductId { get; private set; }
        public Stock(StockId id, int quantity, ProductId productId) : base(id)
        {
            Quantity = quantity;
            ProductId = productId;
        }

        public static Stock Create(int quantity, ProductId productId)
        {
            return new(
                    StockId.Create(Guid.NewGuid()),
                    quantity,
                    productId
                );
        }
    }
}
