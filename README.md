# Rally

An event registration platform. Currently allows users to view a list of hardcoded events.

Future plans may include allowing users to register for events, and allowing event organizers to create and manage events.

Disclaimer: This is a sample application for portfolio purposes. It is not intended to be used in production at this time, but to give me experience with building a web application using .NET 10 and C# with the inclusion of Azure.

## Prerequisites

Must have the following installed on your machine:
- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)
Note: Currently, the global.json pins the SDK version, so any .NET 10.0 SDK version 10.0.404 or higher will work.

## Build and test

To build, run the following command:
```bash
dotnet build
```

To test, run the following command:
```bash
dotnet test
```

## Run locally

Run the following command to start the application locally:
```bash
dotnet run --project src/Rally.Api
```

## Endpoints

- GET /events - Get a list of all events
- GET /health - Get the health status of the application