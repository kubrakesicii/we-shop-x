using WeShopX.Domain.Common;

namespace WeShopX.Domain.ProductManagement.ValueObjects
{
    public record CategoryId(Guid Value) : ValueObject
    {
        public static CategoryId Create(Guid value) => new CategoryId(value);
    }
}
