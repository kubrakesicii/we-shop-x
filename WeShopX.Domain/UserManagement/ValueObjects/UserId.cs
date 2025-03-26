using WeShopX.Domain.Common;

namespace WeShopX.Domain.UserManagement.ValueObjects
{
    public record UserId(Guid Value) : ValueObject
    {
        public static UserId Create() => new UserId(Guid.NewGuid());
    }
}
