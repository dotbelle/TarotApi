using TarotApi.Suits;

namespace TarotApi.Configuration;

public static class ApiExtensions 
{
    public static void AddApiEndpoints(this WebApplication app)
    {
        app.MapGetSuits();

    }
}