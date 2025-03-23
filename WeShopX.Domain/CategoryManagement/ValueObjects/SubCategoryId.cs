using WeShopX.Domain.Common;

namespace WeShopX.Domain.CategoryManagement.ValueObjects
{
    public record SubCategoryId(Guid Value) : ValueObject
    {
        public static SubCategoryId Create(Guid value) => new SubCategoryId(value);
    }
}
