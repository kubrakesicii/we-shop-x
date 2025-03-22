using WeShopX.Domain.Common;

namespace WeShopX.Domain.UserManagement.ValueObjects
{
    public record LoyaltyPointId(Guid Value) : ValueObject
    {
        public static LoyaltyPointId Create(Guid value) => new LoyaltyPointId(value);
    }
}
