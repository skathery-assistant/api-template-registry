using CleanApi.Contracts;
using CleanApi.Infrastructure.Validation;
using Xunit;

namespace CleanApi.Tests;

public sealed class WidgetRequestValidatorTests
{
    [Fact]
    public void Validate_ReturnsNoErrors_ForValidRequest()
    {
        var request = new CreateWidgetRequest("Widget One", 10, "SKU-1");

        var errors = WidgetRequestValidator.Validate(request);

        Assert.Empty(errors);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("  ")]
    public void Validate_ReturnsNameError_WhenNameIsMissing(string? name)
    {
        var request = new CreateWidgetRequest(name, 10, "SKU-1");

        var errors = WidgetRequestValidator.Validate(request);

        Assert.Contains("name", errors.Keys);
    }

    [Fact]
    public void Validate_ReturnsQuantityError_WhenQuantityIsOutOfRange()
    {
        var request = new CreateWidgetRequest("Widget One", 0, "SKU-1");

        var errors = WidgetRequestValidator.Validate(request);

        Assert.Contains("quantity", errors.Keys);
    }
}
