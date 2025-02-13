namespace Domain.Buildings;

public class BuildingProvider
{
    private readonly Dictionary<string, IHarvestableBuilding> _harvestableBuildings = new(); 

    public BuildingProvider(Game game)
    {
        _harvestableBuildings.Add("log",game.GetVillage().LumberjackHouse);
        _harvestableBuildings.Add("stone",game.GetVillage().StoneMine);
        _harvestableBuildings.Add("coal",game.GetVillage().CoalMine);
    }

    public IHarvestableBuilding GetBuilding(string resourceName)
    {
        return _harvestableBuildings[resourceName];
        
    }
}


/*
 switch (resourceName)
        {
            case "log":
                return _game.GetVillage().LumberjackHouse;
            case "stone":
                return _game.GetVillage().StoneMine;
            case "coal":
                return _game.GetVillage().CoalMine;
            default:
                throw new Exception($"Unknown resource name: {resourceName}");
        }
*/