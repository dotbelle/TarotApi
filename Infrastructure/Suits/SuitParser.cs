using System.Text.Json;
using System.Text.Json.Serialization;

namespace Infrastructure.Suits;

public class Suit
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}

public static class SuitParser
{
    public static List<Suit> Parse()
    {
        var path = "/Users/maximilian/repos/Isabelle/TarotApi/Infrastructure/Suits/Suits.json";

        var jsonString = File.ReadAllText(path);

        return JsonSerializer.Deserialize<List<Suit>>(jsonString);

    }

}