using WeShopX.Domain.Common;

namespace WeShopX.Domain.OrderManagement.ValueObjects
{
    public record OrderId(Guid Value) : ValueObject
    {
        public static OrderId Create(Guid value) => new OrderId(value);
    }
}
