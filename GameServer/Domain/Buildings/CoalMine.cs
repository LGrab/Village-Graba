using Interfaces;

namespace Domain.Buildings;

public class CoalMine : IHarvestableBuilding
{
    private readonly string _houseName;
    private readonly int _houseNumber;
    private readonly string _resourceName;
    private int _coalCount;

    public CoalMine(string houseName, int houseNumber, string resourceName)
    {
        _houseName = houseName;
        _houseNumber = houseNumber;
        _resourceName = resourceName;
    }

    public CoalMineDto ToDto()
    {
        return new CoalMineDto(_houseName, _houseNumber, _resourceName, _coalCount);
    }

    public void Harvest()
    {
        _coalCount++;
    }
}

