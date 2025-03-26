using WeShopX.Domain.CategoryManagement.ValueObjects;
using WeShopX.Domain.Common;
using WeShopX.Domain.ProductManagement.Entities;
using WeShopX.Domain.ProductManagement.ValueObjects;

namespace WeShopX.Domain.ProductManagement
{
    public class Product : AggregateRoot<ProductId>
    {
        public Product(ProductId id, string name, string description, string detail,Price price, SubCategoryId categoryId, BrandId brandId,
            string imageUrl) : base(id)
        {
            Name = name;
            Description = description;
            Detail = detail;
            Price = price;
            CategoryId = categoryId;
            BrandId = brandId;
            ImageUrl = imageUrl;

            ProductReviews = _productReviews.AsReadOnly().ToList();
            ProductFeatures = _productFeatures.AsReadOnly().ToList();
        }

        public string Name { get;private set; }
        public string Description { get; private set; }
        public string Detail { get; private set; }
        public Price Price { get; private set; }

        /// <summary>
        /// If Category is an important concept that has business logic and needs to be treated as a separate entity,
        /// you should use a direct entity reference. 
        /// If Category is simpler and doesn't require independent management, it might be better to treat it as
        /// a value object or a foreign key reference.
        /// </summary>
        public SubCategoryId CategoryId { get; private set; }  // ✅ Links to SubCategory, NOT Category
        public BrandId BrandId { get; private set; }
        public StockId StockId { get; private set; }
        public string ImageUrl { get; private set; }

        private readonly List<ProductReview> _productReviews = new();
        public IReadOnlyList<ProductReview> ProductReviews { get; private set; }

        private readonly List<ProductFeature> _productFeatures = new();
        public IReadOnlyList<ProductFeature> ProductFeatures { get; private set; }    
    }
}
