using WeShopX.Domain.Common;

namespace WeShopX.Domain.ProductManagement.ValueObjects
{
    public record BrandId(Guid Value) : ValueObject
    {
        public static BrandId Create(Guid value) => new BrandId(value);
    }
}
