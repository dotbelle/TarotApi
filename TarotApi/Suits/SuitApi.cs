namespace TarotApi.Suits;

public static class GetSuits
{
    public static void MapGetSuits(this WebApplication app)
    {
        app.MapGet("/api/v{version:apiVersion}/suits",
                async (GetSuitsQueryHandler handler) => Results.Ok(new ApiResponse<List<GetSuitsListResponse>>(await handler.Get(), Guid.NewGuid().ToString())))
            .MapToApiVersion(1.0d)
            .WithOpenApi()
            .WithName("GetSuits")
            .WithSummary("Get suits.")
            .WithDescription("Get suits")
            .ProducesCommonErrors();
    }
}
