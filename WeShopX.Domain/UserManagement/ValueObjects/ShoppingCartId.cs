using WeShopX.Domain.Common;

namespace WeShopX.Domain.UserManagement.ValueObjects
{
    public record ShoppingCartId(Guid Value) : ValueObject
    {
        public static ShoppingCartId Create(Guid value) => new ShoppingCartId(value);
    }
}
