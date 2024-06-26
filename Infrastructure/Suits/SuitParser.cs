using System.Text.Json;

namespace Infrastructure.Suits;

internal class Suit {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}

internal class SuitParser
{
    public List<Suit> Parse()
    {
        var path = "./Suits.json";
        var fileContent = File.ReadAllText(path);

        var result = JsonSerializer.Deserialize<List<Suit>>(fileContent);
        return result;
    }

}