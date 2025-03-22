using WeShopX.Domain.Common;
using WeShopX.Domain.ProductManagement.ValueObjects;

namespace WeShopX.Domain.ProductManagement.Entities
{
    public class ProductReview : Entity<ProductReviewId>
    {
        public Guid UserId { get; private set; }  //will type change
        public string Content { get; private set; }
        public string Title { get; private set; }
        public decimal Point { get; private set; }  //1-5
        public ProductReview(ProductReviewId id, Guid userId, string content, string title, decimal point) : base(id)
        {
            UserId = userId;
            Content = content;
            Title = title;
            Point = point;
        }

        public static ProductReview Create( Guid userId, string content, string title, decimal point)
        {
            return new(
                    ProductReviewId.Create(Guid.NewGuid()),
                    userId,
                    content,
                    title,
                    point
                );
        }
    }
}
