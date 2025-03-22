using WeShopX.Domain.Common;
using WeShopX.Domain.UserManagement.ValueObjects;

namespace WeShopX.Domain.UserManagement.Entities
{
    public class LoyaltyPoint : Entity<LoyaltyPointId>
    {
        // when user create an order, will earn point event triggered
        public LoyaltyPoint(LoyaltyPointId id,int point, string reason) : base(id)
        {
            if (point <= 0) throw new ArgumentException("Points must be greater than zero.");

            Point = point;
            Reason = reason;
        }

        public UserId UserId { get; set; }
        public int Point { get; private set; }
        public string Reason { get; private set; }
    }
}
