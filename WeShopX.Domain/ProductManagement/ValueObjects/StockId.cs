using WeShopX.Domain.Common;

namespace WeShopX.Domain.ProductManagement.ValueObjects
{
    public record StockId(Guid Value) : ValueObject
    {
        public static StockId Create(Guid value) => new StockId(value);
    }
}
