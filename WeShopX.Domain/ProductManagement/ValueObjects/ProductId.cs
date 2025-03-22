using WeShopX.Domain.Common;

namespace WeShopX.Domain.ProductManagement.ValueObjects
{
    public record ProductId(Guid Value) : ValueObject;
}
