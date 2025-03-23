using WeShopX.Domain.CategoryManagement.ValueObjects;
using WeShopX.Domain.Common;

namespace WeShopX.Domain.CategoryManagement.Entities
{
    public class SubCategory : Entity<SubCategoryId>
    {
        public SubCategory(SubCategoryId id, CategoryId categoryId,string name) : base(id)
        {
            Name = name;
            CategoryId = categoryId;
        }

        public string Name { get; private set; }
        public CategoryId CategoryId { get; private set; }  // Belongs to a Category

    }
}
