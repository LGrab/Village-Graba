using Interfaces;

namespace Domain.Buildings;

public class HarvestableHouse : IHarvestableBuilding
{
    private readonly int _houseNumber;
    private readonly string _houseName;
    private readonly string _resourceName;
    private readonly string _resourceDisplayName;
    private int _resourceCount; 

    public HarvestableHouse(int houseNumber, string houseName, string resourceName, string resourceDisplayName)
    {
        _houseNumber = houseNumber;
        _houseName = houseName;
        _resourceName = resourceName;
        _resourceDisplayName = resourceDisplayName;
    }

    public HarvestableHouseDto ToDto()
    {
        return new HarvestableHouseDto (_houseNumber,_houseName, _resourceName, _resourceDisplayName, _resourceCount);
        
    }

    public void Harvest()
    {
        _resourceCount++;
    }
}