using System.Text.Json;
using Application.Suits;

namespace Infrastructure.Suits;

public class SuitsParser : ISuitsParser
{
    public List<Suit> ParseSuits()
    {
        var path = "/Users/maximilian/repos/Isabelle/TarotApi/Infrastructure/Suits/Suits.json";

        var jsonString = File.ReadAllText(path);

        return JsonSerializer.Deserialize<List<Suit>>(jsonString);

    }

}