using WeShopX.Domain.Common;

namespace WeShopX.Domain.UserManagement.ValueObjects
{
    public record UserId(Guid Value) : ValueObject
    {
        public static UserId Create(Guid value) => new UserId(value);
    }
}
