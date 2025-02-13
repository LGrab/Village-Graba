namespace Interfaces;

public class CoalMineDto
{
    public string HouseName { get; }
    public int HouseNumber { get; }
    public string ResourceName { get; }
    public int CoalCount { get; }
    public CoalMineDto(string houseName, int houseNumber, string resourceName, int coalCount)
    {
        HouseName = houseName;
        HouseNumber = houseNumber;
        ResourceName = resourceName;
        CoalCount = coalCount;
    }
    
}