namespace CleanApi.Contracts;

public sealed record CreateWidgetRequest(string? Name, int Quantity, string? Sku);
