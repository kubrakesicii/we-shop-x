
using WeShopX.Domain.Common;

namespace WeShopX.Domain.VendorManagement.ValueObjects
{
    public record VendorId(Guid Value) : ValueObject
    {
        public static VendorId Create(Guid value) => new VendorId(value);
    }
}
