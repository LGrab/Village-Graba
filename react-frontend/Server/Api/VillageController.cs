using Application.Web.Common.ErrorHandling;
using Domain;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Server.Api.Models;

namespace Server.Api;

[ApiController]
[Route("api/[controller]")]
public class VillageController : ControllerBase
{
    private readonly IDummyDomain _dummyDomain;
    private readonly HttpClient _httpClient;

    public VillageController(
        IDummyDomain dummyDomain,
        HttpClient httpClient
    )
    {
        _dummyDomain = dummyDomain;
        _httpClient = httpClient;
    }


    [HttpGet("[action]")]
    public VillageDto GetVillage()
    {
        var village = _httpClient.GetFromJsonAsync<VillageDto>("http://localhost:5555/game").Result;
        return village!;
    }

    [HttpPost("[action]")]
    public ErrorResponse HarvestLog(HarvestLogInput input)
    {
        var response = _httpClient.PostAsJsonAsync("http://localhost:5555/game/harvest", new HarvestCommandDto("log"))
            .Result;
        if (!response.IsSuccessStatusCode)
        {
            return new ErrorResponse("Kladu se nepovedlo natezit");
        }
        return new ErrorResponse();
    }

    [HttpPost("[action]")]
    public ErrorResponse HarvestStone(HarvestStoneInput input)
    {
        var response = _httpClient.PostAsJsonAsync("http://localhost:5555/game/harvest", new HarvestCommandDto("stone"))
            .Result;
        if (!response.IsSuccessStatusCode)
        {
            return new ErrorResponse("Kamen nejde natezit");
        }
        return new ErrorResponse();
    }

    [HttpPost("[action]")]
    public ErrorResponse HarvestCoal(HarvestCoalInput input)
    {
        var response = _httpClient.PostAsJsonAsync("http://localhost:5555/game/harvest", new HarvestCommandDto("coal"))
            .Result;
        if (!response.IsSuccessStatusCode)
        {
            return new ErrorResponse("Uhli nejde natezit");
        }
        return new ErrorResponse();
    }



    /*
    // tohle poradila AI

    [HttpPost("[action]")]
    public ErrorResponse Harvest<TInput, TDto>(TInput input, string url, string errorMessage)
    {
        var response = _httpClient.PostAsJsonAsync(url, Activator.CreateInstance<TDto>()).Result;
        if (!response.IsSuccessStatusCode)
        {
            return new ErrorResponse(errorMessage);
        }
        return new ErrorResponse();
    }

    [HttpPost("[action]")]
    public ErrorResponse HarvestLogAAA(HarvestLogInput input)
    {
        return Harvest<HarvestLogInput, HarvestLogDto>(input, "http://localhost:5555/game/harvest_log", "Kladu se nepovedlo natezit");
    }

    [HttpPost("[action]")]
    public ErrorResponse HarvestStoneAAA(HarvestStoneInput input)
    {
        return Harvest<HarvestStoneInput, HarvestStoneDto>(input, "http://localhost:5555/game/harvest_stone", "Kamen nejde natezit");
    }

    [HttpPost("[action]")]
    public ErrorResponse HarvestCoalAAA(HarvestCoalInput input)
    {
        return Harvest<HarvestCoalInput, HarvestStoneDto>(input, "http://localhost:5555/game/harvest_coal", "Uhli nejde natezit");
    }

    */

}

public record HarvestLogInput();
public record HarvestStoneInput();
public record HarvestCoalInput();


public class HarvestLogDto
{ }

public class HarvestStoneDto
{ }

public class HarvestCoalDto
{ }
