using WeShopX.Domain.Common;

namespace WeShopX.Domain.OrderManagement.ValueObjects
{
    public record OrderItemId(Guid Value) : ValueObject
    {
        public static OrderItemId Create(Guid value) => new OrderItemId(value);
    }
}
