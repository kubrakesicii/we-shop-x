using WeShopX.Domain.Common;
using WeShopX.Domain.ProductManagement.Entities;

namespace WeShopX.Domain.ProductManagement.ValueObjects
{
    public record ProductFeatureId(Guid Value) : ValueObject
    {
        public static ProductFeatureId Create(Guid value) => new ProductFeatureId(value);
    }
}
