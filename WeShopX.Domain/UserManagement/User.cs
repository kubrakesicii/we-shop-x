using WeShopX.Domain.Common;
using WeShopX.Domain.OrderManagement;
using WeShopX.Domain.ProductManagement;
using WeShopX.Domain.UserManagement.Entities;
using WeShopX.Domain.UserManagement.ValueObjects;

namespace WeShopX.Domain.UserManagement
{
    public class User : AggregateRoot<UserId>
    {

        public User(UserId id,string firstname, string lastname, string email, string mobileNo, float weight, float height) : base(id)
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

        private readonly List<Product> _favoriteProducts = new();
        public IReadOnlyList<Product> FavoriteProducts { get; private set; }

        private readonly List<Address> _savedAddresses = new();
        public IReadOnlyList<Address> SavedAddresses { get; private set; }

        private readonly List<LoyaltyPoint> _loyaltyPoints = new();
        public IReadOnlyList<LoyaltyPoint> LoyaltyPoints { get; private set; }

        private readonly List<Order> _orders = new();
        public IReadOnlyList<Order> Orders { get; private set; }


        //private readonly List<Coupos> _coupons = new();
        //public IReadOnlyList<Coupon> v { get; private set; }


    }
}
