namespace Application.Suits;

public class GetSuitsQueryHandler(ISuitsParser suitsParser)
{
    public List<Suit> GetSuits()
    {
        var suits = suitsParser.ParseSuits();

        return suits;
    }
}