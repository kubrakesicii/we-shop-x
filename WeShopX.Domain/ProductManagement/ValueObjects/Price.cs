using WeShopX.Domain.Common;

namespace WeShopX.Domain.ProductManagement.ValueObjects
{
    public record Price(string Currency, decimal Amount) : ValueObject
    {
        public static Price Create(string currency, decimal amount) => new Price(currency, amount);
    }
}
