using CleanApi.Contracts;
using CleanApi.Infrastructure.Validation;

namespace CleanApi.Features.Widgets;

public static class WidgetEndpoints
{
    public static RouteGroupBuilder MapWidgetEndpoints(this RouteGroupBuilder group)
    {
        group.MapGet("/", (WidgetStore store) => Results.Ok(store.GetAll().Select(WidgetResponse.FromDomain)))
            .WithName("ListWidgets");

        group.MapGet("/{id:guid}", (Guid id, WidgetStore store) =>
        {
            if (!store.TryGet(id, out var widget))
            {
                return Results.NotFound();
            }

            return Results.Ok(WidgetResponse.FromDomain(widget));
        })
        .WithName("GetWidget");

        group.MapPost("/", (CreateWidgetRequest request, WidgetStore store) =>
        {
            var errors = WidgetRequestValidator.Validate(request);
            if (errors.Count > 0)
            {
                return Results.ValidationProblem(errors);
            }

            var widget = store.Create(request);
            return Results.CreatedAtRoute(
                routeName: "GetWidget",
                routeValues: new { id = widget.Id },
                value: WidgetResponse.FromDomain(widget));
        })
        .WithName("CreateWidget");

        return group;
    }
}
