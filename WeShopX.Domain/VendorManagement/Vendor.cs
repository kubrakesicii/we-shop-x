using WeShopX.Domain.Common;
using WeShopX.Domain.ProductManagement.ValueObjects;
using WeShopX.Domain.VendorManagement.ValueObjects;

namespace WeShopX.Domain.VendorManagement
{
    public class Vendor : AggregateRoot<VendorId>
    {
        public Vendor(VendorId id,string name, string description, string imageUrl, StoreRating storeRating) : base(id)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
            StoreRating = storeRating;
            Products = _products.AsReadOnly().ToList();
        }

        public string Name { get; private set; }
        public string Description { get;  private set; }
        public string ImageUrl { get;  private set; }
        public StoreRating StoreRating { get; private set; }

        public IReadOnlyList<ProductId> Products { get; }
        private readonly List<ProductId> _products = new();


        public static Vendor Create(string name, string description, string imageUrl)
        {
            return new(
                    VendorId.Create(Guid.NewGuid()),
                    name,
                    description,
                    imageUrl,
                    StoreRating.Create(0, 10)  // starts with 10 rating
                    );
        }
    }
}
