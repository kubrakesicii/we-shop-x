using WeShopX.Domain.Common;
using WeShopX.Domain.MarketingManagement.ValueObjects;

namespace WeShopX.Domain.MarketingManagement
{
    public class Coupon : AggregateRoot<CouponId>
    {
        public Coupon(CouponId id,string code, decimal discountAmount, bool ısPercentage, int maxUsage, int usageCount, DateTime expirationDate) : base(id)
        {
            Code = code;
            DiscountAmount = discountAmount;
            IsPercentage = ısPercentage;
            MaxUsage = maxUsage;
            UsageCount = usageCount;
            ExpirationDate = expirationDate;
        }

        public string Code { get; private set; }
        public decimal DiscountAmount { get; private set; }
        public bool IsPercentage { get; private set; }
        public int MaxUsage { get; private set; }
        public int UsageCount { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public bool IsValid => DateTime.UtcNow <= ExpirationDate && UsageCount < MaxUsage;
    }
}
