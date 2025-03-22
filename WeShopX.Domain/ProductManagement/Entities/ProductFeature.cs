using WeShopX.Domain.Common;
using WeShopX.Domain.ProductManagement.ValueObjects;

namespace WeShopX.Domain.ProductManagement.Entities
{
    public class ProductFeature : Entity<ProductFeatureId>
    {
        public string Name { get; private set; }
        public string Value { get; private set; }
        public ProductId ProductId { get; set; }

        public ProductFeature(ProductFeatureId id, string name, string value) : base(id)
        {
            Name = name;
            Value = value;
        }

        public static ProductFeature Create(string name, string value)
        {
            return new(
                    ProductFeatureId.Create(Guid.NewGuid()),
                    name,
                    value
                );
        }
    }
}
