using Domain;
using Domain.Buildings;
using Interfaces;
using Technology.Json;

namespace Technology.Http;

public class HttpGameServer// : IGameServer
{
    private readonly IResponseValues _responseValues;
    private readonly ITest _test;
    private readonly Game _game;
    private readonly BuildingProvider _buildingProvider;
    private readonly JsonDeserializer _jsonDeserializer;

    public HttpGameServer(IResponseValues responseValues, ITest test, Game game, BuildingProvider buildingProvider, JsonDeserializer jsonDeserializer)
    {
        _responseValues = responseValues;
        _test = test;
        _game = game;
        _buildingProvider = buildingProvider;
        _jsonDeserializer = jsonDeserializer;
    }
    
    public static void Create(WebApplicationBuilder builder)
    {
        builder.WebHost.ConfigureKestrel(options =>
        {
            options.ListenAnyIP(5555); // Replace 5001 with your custom port
        });
    }

    public void MapRequests(WebApplication webApplication)
    {
        webApplication.MapGet("/", () => _responseValues.GetGreetingMessage()); // Simple endpoint
        webApplication.MapGet("/test", () => _test.GetTestMessage()); 
        
        webApplication.MapGet("/game", () =>
        {
            return Results.Json(_game.GetVillage().ToDto());
        });
        
        
        
        //napovedela AI
        webApplication.MapPost("/game/harvest", async (HttpContext context) => {
            
                var data = await _jsonDeserializer.DeserializeAsync(context.Request.Body);
                
                if (data == null)
                {
                    return Results.BadRequest("Invalid data.");
                }
                
                // diky Factory "patternu" tohle se jmenuje provider
                _buildingProvider.GetBuilding(data.ResourceName).Harvest();
                
               return Results.Json("OK");
        });
    }

}


/*
 resime single responsibility
 ********************************
 
   webApplication.MapPost("/game/harvest", async (HttpContext context) => {
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
    
                // JSON deserializace 
                var data = await JsonSerializer.DeserializeAsync<HarvestCommandDto>(context.Request.Body, options);

                if (data == null)
                {
                    return Results.BadRequest("Invalid data.");
                }
                
                //
                // diky Factory "patternu" tohle se jmenuje provider patri doHRY HRAVESTUJEEM
                _buildingProvider.GetBuilding(data.ResourceName).Harvest();
                
                /// patri do HTTP svera
               return Results.Json("OK");
            }
        });
        
        
        
        
        222222222222222222222
            private static async Task<HarvestCommandDto?> DeserializeAsync(HttpContext context)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var data = await JsonSerializer.DeserializeAsync<HarvestCommandDto>(context.Request.Body, options);
        return data;
    }
        
 
 
 
 
 
 
 
 
   switch (data.ResourceName)
                {
                    case "log":
                        _game.GetVillage().LumberjackHouse.Harvest();
                        break;
                    case "stone":
                        _game.GetVillage().StoneMine.Harvest();
                        break;
                    case "coal":
                        _game.GetVillage().CoalMine.Harvest();
                        break;
                    default:
                        return Results.Json("Unable to add resource");
                }
                return Results.Json("OK");
 
 
 
 
 
 
 
 
 
        webApplication.MapPost("/game/harvest_log", () =>
        {
            _game.GetVillage().LumberjackHouse.Harvest();
            return Results.Json("OK");
        });
        
        webApplication.MapPost("/game/harvest_stone", () =>
        {
            _game.GetVillage().StoneMine.Harvest();
            return Results.Json("OK");
        });
        
        webApplication.MapPost("/game/harvest_coal", () =>
        {
            _game.GetVillage().CoalMine.Harvest();
            return Results.Json("OK");
        });
        
        */