using Domain.Common.Contracts;
using Domain.Enums;

namespace Domain.Entities;

public class Farm : AuditableEntity
{
    public string FarmName { get; private set; }
    public string LocatedCity { get; private set; }
    public CropType CropType { get; private set; }
    public Guid FarmerId { get; private set; }
    public Farm(string farmName, string locatedCity, CropType type, Guid farmerId)
    {
        FarmName = farmName;
        LocatedCity = locatedCity;
        CropType = type;
        FarmerId = farmerId;
    }
}
