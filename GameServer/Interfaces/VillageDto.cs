namespace Interfaces;

public class VillageDto
{
    public HarvestableHouseDto HarvestableHouse { get; }
    
    
    
    public VillageDto(HarvestableHouseDto harvestableHouse)
    {
        HarvestableHouse = harvestableHouse;
    }
    
}



/*
 
     public LumberjackHouseDto Lumberjack { get; }
    public StoneMineDto StoneMine { get; }
    public CoalMineDto CoalMine { get; }
    
    public VillageDto(LumberjackHouseDto lumberjack, StoneMineDto stoneMine, CoalMineDto coalMine)
    {
        Lumberjack = lumberjack;
        StoneMine = stoneMine;
        CoalMine = coalMine;
    }
 
 
 
 
 
 
 
 
 
namespace Domain.Interfaces;

public class VillageDto
{
    public VillageDto(LumberjackHouseDto lumberjack)
    {
        Lumberjack = lumberjack;
    }
    public LumberjackHouseDto Lumberjack { get; }
}
*/