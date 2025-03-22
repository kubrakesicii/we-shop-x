using WeShopX.Domain.Common;

namespace WeShopX.Domain.UserManagement.ValueObjects
{
    public record CartItemId(Guid Value) : ValueObject
    {
        public static CartItemId Create(Guid value) => new CartItemId(value);
    }
}
