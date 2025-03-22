using WeShopX.Domain.Common;
using WeShopX.Domain.ProductManagement.ValueObjects;

namespace WeShopX.Domain.ProductManagement.Entities
{
    public class Brand : Entity<BrandId>
    {
        public string Name { get; private set; }
        public Brand(BrandId id, string name) : base(id)
        {
            Name = name;
        }

        public static Brand Create(string name)
        {
            return new(
                    BrandId.Create(Guid.NewGuid()),
                    name
                );
        }
    }
}
