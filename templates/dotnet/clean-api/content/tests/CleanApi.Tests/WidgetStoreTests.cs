using CleanApi.Contracts;
using CleanApi.Features.Widgets;
using Xunit;

namespace CleanApi.Tests;

public sealed class WidgetStoreTests
{
    [Fact]
    public void Create_And_GetAll_ReturnsCreatedWidget()
    {
        var store = new WidgetStore();
        var request = new CreateWidgetRequest("Widget One", 5, "SKU-1");

        var created = store.Create(request);

        var allWidgets = store.GetAll();

        Assert.Single(allWidgets);
        Assert.Equal(created.Id, allWidgets.First().Id);
        Assert.Equal("Widget One", allWidgets.First().Name);
    }
}
