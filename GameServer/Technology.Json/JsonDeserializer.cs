using System.Text.Json;
using Interfaces;

namespace Technology.Json;

public class JsonDeserializer
{
    public async Task<HarvestCommandDto?> DeserializeAsync(Stream json)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var data = await JsonSerializer.DeserializeAsync<HarvestCommandDto>(json, options);
        return data;
    }
    
}