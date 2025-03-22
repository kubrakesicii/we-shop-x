using WeShopX.Domain.Common;

namespace WeShopX.Domain.UserManagement.ValueObjects
{
    public record AddressId(Guid Value) : ValueObject
    {
        public static AddressId Create(Guid value) => new AddressId(value);
    }
}
