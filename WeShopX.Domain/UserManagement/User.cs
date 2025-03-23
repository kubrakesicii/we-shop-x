using WeShopX.Domain.Common;
using WeShopX.Domain.OrderManagement.ValueObjects;
using WeShopX.Domain.ProductManagement.ValueObjects;
using WeShopX.Domain.UserManagement.Entities;
using WeShopX.Domain.UserManagement.ValueObjects;

namespace WeShopX.Domain.UserManagement
{
    public class User : AggregateRoot<UserId>
    {

        public User(UserId id,string firstname, string lastname, Email email, MobileNo mobileNo, float weight, float height) : base(id)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            MobileNo = mobileNo;
            Weight = weight;
            Height = height;

            FavoriteProducts = _favoriteProducts.AsReadOnly().ToList();
            SavedAddresses = _savedAddresses.AsReadOnly().ToList();
            LoyaltyPoints = _loyaltyPoints.AsReadOnly().ToList();
            Orders = _orders.AsReadOnly().ToList();
        }

        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public Email Email { get; private set; }
        public MobileNo MobileNo { get; private set; }
        public float Weight { get; private set; }
        public float Height { get; private set; }
        public ShoppingCart Cart { get; private set; }

        private readonly List<ProductId> _favoriteProducts = new();
        public IReadOnlyList<ProductId> FavoriteProducts { get; private set; }

        private readonly List<Address> _savedAddresses = new();
        public IReadOnlyList<Address> SavedAddresses { get; private set; }

        private readonly List<LoyaltyPoint> _loyaltyPoints = new();
        public IReadOnlyList<LoyaltyPoint> LoyaltyPoints { get; private set; }

        private readonly List<OrderId> _orders = new();
        public IReadOnlyList<OrderId> Orders { get; private set; }


        //private readonly List<Coupos> _coupons = new();
        //public IReadOnlyList<Coupon> v { get; private set; }


    }
}
