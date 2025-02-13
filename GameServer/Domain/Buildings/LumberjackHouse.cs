using Interfaces;

namespace Domain.Buildings;

public class LumberjackHouse : IHarvestableBuilding
{
    private readonly string _houseName;
    private readonly int _houseNumber;
    private readonly string _resourceName;
    private int _logCount; 

    public LumberjackHouse(string houseName, int houseNumber, string resourceName)
    {
        _houseName = houseName;
        _houseNumber = houseNumber;
        _resourceName = resourceName;
    }

    public LumberjackHouseDto ToDto()
    {
        return new LumberjackHouseDto (_houseName, _houseNumber, _resourceName, _logCount);
        
    }

    public void Harvest()
    {
        _logCount++;
    }
}