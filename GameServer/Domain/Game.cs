namespace Domain;

public class Game
{
    private Village _village;
    
    public void RunGame()
    {
        _village = new Village();
        
    }

    public Village GetVillage()
    {
        return _village;
    }
}



    /*
    public void HarvestLog()
    {
     _village.LumberjackHouse.Harvest();
    }

    public void HarvestStone()
    { 
        _village.StoneMine.Harvest();
    }

    public void HarvestCoal()
    {
        _village.CoalMine.Harvest();
    }
    */
