using Microsoft.AspNetCore.Mvc.Testing;
using Rally.Api.Events;
using System.Net.Http.Json;

namespace Rally.Api.Tests;

public class EventEndpointTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public EventEndpointTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task EventEndpoint_Returns200WithListOfEvents()
    {
        // Arrange
        var client = _factory.CreateClient();
        var expectedCode = System.Net.HttpStatusCode.OK;

        // Act
        var response = await client.GetAsync("/events");

        // Assert

        var result = await response.Content.ReadFromJsonAsync<Event[]>();


        Assert.Equal(expectedCode, response.StatusCode);
        Assert.NotNull(result);
        Assert.Equal(3, result.Length);
    }
}
