
using WeShopX.Domain.Common;

namespace WeShopX.Domain.VendorManagement.ValueObjects
{
    public record StoreRating(int NumOfRate, float Value) : ValueObject
    {
        public static StoreRating Create(int numOfRate, float value) => new StoreRating(numOfRate, value);
    }
}
