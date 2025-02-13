using Interfaces;

namespace Domain.Buildings;

public class StoneMine : IHarvestableBuilding
{
    private readonly string _houseName;
    private readonly int _houseNumber;
    private readonly string _resourceName;
    private int _stoneCount;

    public StoneMine(string houseName, int houseNumber, string resourceName)
    {
        _houseNumber = houseNumber;
        _houseName = houseName;
        _resourceName = resourceName;
    }
    public StoneMineDto ToDto()
    {
        return new StoneMineDto(_houseName,_houseNumber, _resourceName, _stoneCount);
    }

    public void Harvest()
    {
        _stoneCount++;
    }
}




    /*public int GethouseNumber()
    {
        return _houseNumber;
    }

    public int GetStoneCount()
    {
        return _stoneCount;
    }*/
