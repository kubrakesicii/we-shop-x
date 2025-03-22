using WeShopX.Domain.Common;

namespace WeShopX.Domain.ProductManagement.ValueObjects
{
    public record ProductReviewId(Guid Value) : ValueObject
    {
        public static ProductReviewId Create(Guid value) => new ProductReviewId(value);
    }
}
