using WeShopX.Domain.CategoryManagement.Entities;
using WeShopX.Domain.CategoryManagement.ValueObjects;
using WeShopX.Domain.Common;

namespace WeShopX.Domain.CategoryManagement
{
    public class Category : AggregateRoot<CategoryId>
    {
        public Category(CategoryId id, string name) : base(id)
        {
            Name = name;

            SubCategories = _subCategories.AsReadOnly().ToList();
        }

        public string Name { get; private set; }
        private readonly List<SubCategory> _subCategories = new();
        public IReadOnlyList<SubCategory> SubCategories { get; private set; }

   

    }
}
