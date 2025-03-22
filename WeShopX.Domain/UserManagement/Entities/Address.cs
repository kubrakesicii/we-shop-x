using WeShopX.Domain.Common;
using WeShopX.Domain.UserManagement.ValueObjects;

namespace WeShopX.Domain.UserManagement.Entities
{
    public class Address : Entity<AddressId>
    {
        public Address(AddressId id,int cityId, int districtId, int neighbourhoodId, string detail, string title) : base(id)
        {
            CityId = cityId;
            DistrictId = districtId;
            NeighbourhoodId = neighbourhoodId;
            Detail = detail;
            Title = title;
        }

        public int CityId { get; private set; }
        public int DistrictId { get; private set; }
        public int NeighbourhoodId { get; private set; }
        public string Detail { get; private set; }
        public string Title { get; private set; }
    }
}
