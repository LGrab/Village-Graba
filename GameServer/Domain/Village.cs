using Domain.Buildings;
using Interfaces;

namespace Domain;

public class Village
{
    
    //pridat list s baraky
    private readonly List<HarvestableHouse> _harvestableHouses = new List<HarvestableHouse>();


    public Village()
    {
        _harvestableHouses.Add(new HarvestableHouse(1, "LumberJack","Log", "Dřevo"));
        
    }

    public VillageDto ToDto()
    {
        return _harvestableHouses;//todo: tohle vyresit aby se vraceli vsechny domy jako dto.
                                  //DTO mi akceptuje tridu, ale ja potrebuju vloyit do toho list vsech domu
    }
}


/*
 
   public LumberjackHouse LumberjackHouse { get; }
    public StoneMine StoneMine { get; }
    public CoalMine CoalMine { get; }

    public Village()
    {
        LumberjackHouse = new LumberjackHouse("Dřevorubec", 545, "Dřevo");
        StoneMine = new StoneMine("Kamenolom", 222, "Kámen");
        CoalMine = new CoalMine("Uhelný důl", 323, "Uhlí");
    }


    public VillageDto ToDto()
    {
        return new VillageDto(LumberjackHouse.ToDto(), StoneMine.ToDto(), CoalMine.ToDto());
    }
 
 
 
 
using Domain.Interfaces;

namespace Domain;


public class Village
{
    public LumberjackHouse _lumberjack;

    public Village()
    {
        _lumberjack = new LumberjackHouse(1166);
    }


    public VillageDto ToDto()
    {
        return new VillageDto(new LumberjackHouseDto(_lumberjack.HouseNumber, _lumberjack.LogCount));
    }
}

*/