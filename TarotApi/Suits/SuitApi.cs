namespace TarotApi.Suits;

internal static class TarotApi
{
    public static RouteGroupBuilder MapSuits(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/Suit");

        group.WithTags("Suits");

        group.MapGet("/{id}", async SuitQueryHandler => 
        {

        });

        return group;
    }
}