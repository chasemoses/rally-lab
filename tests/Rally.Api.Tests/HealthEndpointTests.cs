using Microsoft.AspNetCore.Mvc.Testing;

namespace Rally.Api.Tests;

public class HealthEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;
    public HealthEndpointTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task HealthEndpoint_ReturnsWith200()
    {
        // Arrange
        var client = _factory.CreateClient();
        var expectedCode = System.Net.HttpStatusCode.OK;

        // Act
        var response = await client.GetAsync("/health");

        // Assert

        Assert.Equal(expectedCode, response.StatusCode);
    }
}
