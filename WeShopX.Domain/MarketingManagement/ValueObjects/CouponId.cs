using WeShopX.Domain.Common;

namespace WeShopX.Domain.MarketingManagement.ValueObjects
{
    public record CouponId(Guid Value) : ValueObject
    {
        public static CouponId Create(Guid value) => new CouponId(value);
    }
}
