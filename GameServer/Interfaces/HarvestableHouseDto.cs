namespace Interfaces;

public class HarvestableHouseDto
{
    public int HouseNumber { get; }
    public string HouseName { get; }
    public string ResourceName { get; }
    public string ResourceDisplayName { get; }
    public int ResourceCount { get; }
    public HarvestableHouseDto(int houseNumber, string houseName, string resourceName, string resourceDisplayName, int resourceCount)
    {
        HouseNumber = houseNumber;
        HouseName = houseName;
        ResourceName = resourceName;
        ResourceDisplayName = resourceDisplayName;
        ResourceCount = resourceCount;
    }
    
}

