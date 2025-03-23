using WeShopX.Domain.Common;

namespace WeShopX.Domain.CategoryManagement.ValueObjects
{
    public record CategoryId(Guid Value) : ValueObject
    {
        public static CategoryId Create(Guid value) => new CategoryId(value);
    }
}
