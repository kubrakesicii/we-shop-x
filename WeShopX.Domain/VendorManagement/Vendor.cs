using WeShopX.Domain.Common;
using WeShopX.Domain.VendorManagement.ValueObjects;

namespace WeShopX.Domain.VendorManagement
{
    public class Vendor : AggregateRoot<VendorId>
    {
        public Vendor(VendorId id,string name, string description, StoreRating storeRating) : base(id)
        {
            Name = name;
            Description = description;
            StoreRating = storeRating;
            Products = _products.AsReadOnly().ToList();
        }

        public string Name { get; private set; }
        public string Description { get;  private set; }
        public StoreRating StoreRating { get; private set; }

        public IReadOnlyList<Guid> Products { get; }
        private readonly List<Guid> _products = new();


        public static Vendor Create(string name, string description)
        {
            return new(
                    VendorId.Create(Guid.NewGuid()),
                    name,
                    description,
                    StoreRating.Create(0, 10)  // starts with 10 rating
                    );
        }
    }
}
