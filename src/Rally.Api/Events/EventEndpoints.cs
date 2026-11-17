namespace Rally.Api.Events;

public static class EventEndpoints
{
    public static IEndpointRouteBuilder MapEventEndpoints(this IEndpointRouteBuilder app)
    {
        Event[] events = new Event[]
        {
            new Event(Guid.NewGuid(), "Event 1", DateTimeOffset.Now.AddDays(1), "Location 1", 100),
            new Event(Guid.NewGuid(), "Event 2", DateTimeOffset.Now.AddDays(2), "Location 2", 200),
            new Event(Guid.NewGuid(), "Event 3", DateTimeOffset.Now.AddDays(3), "Location 3", 300)
        };

        var group = app.MapGroup("/events");

        // your MapGet goes here, on the group
        group.MapGet("/", () => events)
        .WithName("GetEvents");

        return app;
    }
}
