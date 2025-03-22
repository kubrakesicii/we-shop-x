using WeShopX.Domain.Common;

namespace WeShopX.Domain.UserManagement.ValueObjects
{
    public record Email(string Value) : ValueObject
    {
        public static Email Create(string value)
        {
            // validation of email, if it is includes @ char, or reg exp validation
            return new Email(value);
        }
    }
}
