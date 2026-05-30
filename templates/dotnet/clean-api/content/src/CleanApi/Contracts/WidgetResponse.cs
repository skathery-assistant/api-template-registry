using CleanApi.Features.Widgets;

namespace CleanApi.Contracts;

public sealed record WidgetResponse(
    Guid Id,
    string Name,
    int Quantity,
    string? Sku,
    DateTimeOffset CreatedAtUtc)
{
    public static WidgetResponse FromDomain(Widget widget)
        => new(widget.Id, widget.Name, widget.Quantity, widget.Sku, widget.CreatedAtUtc);
}
