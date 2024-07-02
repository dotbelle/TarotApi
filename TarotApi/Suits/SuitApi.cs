using Application.Suits;

namespace TarotApi.Suits;

public static class GetSuits
{
    public static void MapGetSuits(this WebApplication app)
    {
        app.MapGet("/api/v{version:apiVersion}/suits", (GetSuitsQueryHandler handler) => Results.Ok(handler.GetSuits()))
            .WithOpenApi()
            .WithName("GetSuits")
            .WithSummary("Get suits.")
            .WithDescription("Get suits");
    }
}
