namespace CleanApi.Features.Widgets;

public sealed record Widget(
    Guid Id,
    string Name,
    int Quantity,
    string? Sku,
    DateTimeOffset CreatedAtUtc);
