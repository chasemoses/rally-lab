namespace Rally.Api.Events;

public record Event(Guid Id, string Name, DateTimeOffset StartsAt, string Location, int Capacity);
