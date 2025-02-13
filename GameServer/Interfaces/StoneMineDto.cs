namespace Interfaces;

public class StoneMineDto
{
    public string HouseName { get; }
    public int HouseNumber { get; }
    public string ResourceName { get; }
    public int StoneCount { get; }

    public StoneMineDto(string houseName, int houseNumber, string resourceName, int stoneCount)
    {
        HouseName = houseName;
        HouseNumber = houseNumber;
        ResourceName = resourceName;
        StoneCount = stoneCount;
    }
}