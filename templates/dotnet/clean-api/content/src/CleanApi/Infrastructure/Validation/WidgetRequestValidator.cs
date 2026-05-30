using CleanApi.Contracts;

namespace CleanApi.Infrastructure.Validation;

public static class WidgetRequestValidator
{
    public static Dictionary<string, string[]> Validate(CreateWidgetRequest request)
    {
        var errors = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

        AddIf(string.IsNullOrWhiteSpace(request.Name), "name", "Name is required.");
        AddIf(!string.IsNullOrWhiteSpace(request.Name) && request.Name.Trim().Length < 3, "name", "Name must be at least 3 characters long.");
        AddIf(request.Quantity < 1, "quantity", "Quantity must be at least 1.");
        AddIf(request.Quantity > 1000, "quantity", "Quantity cannot exceed 1000.");
        AddIf(request.Sku is { Length: > 0 } sku && sku.Trim().Length > 32, "sku", "Sku cannot exceed 32 characters.");

        return errors.ToDictionary(
            pair => pair.Key,
            pair => pair.Value.Distinct(StringComparer.Ordinal).ToArray(),
            StringComparer.OrdinalIgnoreCase);

        void AddIf(bool condition, string key, string message)
        {
            if (!condition)
            {
                return;
            }

            if (!errors.TryGetValue(key, out var messages))
            {
                messages = [];
                errors[key] = messages;
            }

            messages.Add(message);
        }
    }
}
