namespace Interfaces;

public class LumberjackHouseDto
{
    public string HouseName { get; }
    public int HouseNumber { get; }
    public string ResourceName { get; }
    public int LogCount { get; }
    public LumberjackHouseDto(string houseName, int houseNumber, string resourceName, int logCount)
    {
        HouseName = houseName;
        HouseNumber = houseNumber;
        ResourceName = resourceName;
        LogCount = logCount;
    }

}




/*
namespace Domain.Interfaces;

public class LumberjackHouseDto
{
    public LumberjackHouseDto(int houseNumber, int logCount)
    {
        HouseNumber = houseNumber;
        LogCount = logCount;
    }

    public int HouseNumber { get; }
    public int LogCount { get; }

}
*/