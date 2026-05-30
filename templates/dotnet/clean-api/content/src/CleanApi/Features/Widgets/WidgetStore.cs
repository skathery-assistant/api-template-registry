using CleanApi.Contracts;
using System.Collections.Concurrent;

namespace CleanApi.Features.Widgets;

public sealed class WidgetStore
{
    private readonly ConcurrentDictionary<Guid, Widget> _widgets = new();

    public Widget Create(CreateWidgetRequest request)
    {
        var widget = new Widget(
            Id: Guid.NewGuid(),
            Name: request.Name!.Trim(),
            Quantity: request.Quantity,
            Sku: string.IsNullOrWhiteSpace(request.Sku) ? null : request.Sku.Trim(),
            CreatedAtUtc: DateTimeOffset.UtcNow);

        _widgets[widget.Id] = widget;
        return widget;
    }

    public IReadOnlyCollection<Widget> GetAll()
        => _widgets.Values.OrderBy(widget => widget.CreatedAtUtc).ToArray();

    public bool TryGet(Guid id, out Widget widget)
        => _widgets.TryGetValue(id, out widget!);
}
