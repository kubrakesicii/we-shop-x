using WeShopX.Domain.Common;
using WeShopX.Domain.MarketingManagement;
using WeShopX.Domain.MarketingManagement.ValueObjects;
using WeShopX.Domain.OrderManagement.Entities;
using WeShopX.Domain.OrderManagement.ValueObjects;
using WeShopX.Domain.UserManagement.ValueObjects;

namespace WeShopX.Domain.OrderManagement
{
    public class Order : AggregateRoot<OrderId>
    {
        public Order(OrderId id, UserId userId, decimal totalAmount, CouponId? appliedCouponId) : base(id)
        {
            UserId = userId;
            OrderItems = _orderItems.AsReadOnly().ToList();
            TotalAmount = totalAmount;
            AppliedCouponId = appliedCouponId;
        }

        public UserId UserId { get; private set; }
         public decimal TotalAmount { get; private set; }
        public CouponId? AppliedCouponId { get; private set; }

        private readonly List<OrderItem> _orderItems = new();
        public IReadOnlyList<OrderItem> OrderItems { get; private set; }
    }
}
