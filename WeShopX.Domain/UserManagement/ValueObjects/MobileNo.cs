using WeShopX.Domain.Common;

namespace WeShopX.Domain.UserManagement.ValueObjects
{
    public record MobileNo(string CountryCode, string Number) : ValueObject
    {
        public static MobileNo Create(string countryCode, string number) => new MobileNo(countryCode, number);


    }
}
