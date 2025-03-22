using WeShopX.Domain.Common;
using WeShopX.Domain.ProductManagement.ValueObjects;
using WeShopX.Domain.VendorManagement.ValueObjects;

namespace WeShopX.Domain.ProductManagement.Entities
{
    public class Category : Entity<CategoryId>
    {
        public string Name { get; private set; }
        public VendorId VendorId { get; private set; }
        public Category(CategoryId id, string name, VendorId vendorId) : base(id)
        {
            Name = name;
            VendorId = vendorId;
        }

        public static Category Create(string name, VendorId vendorId)
        {
            return new(
                    CategoryId.Create(Guid.NewGuid()),
                    name,
                    vendorId
                );
        }
    }
}
