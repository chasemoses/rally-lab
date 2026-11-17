# Rally

An event registration platform. It allows users to create and manage events, register for events, and view event details. The platform is designed to be scalable, secure, and easy to use.

## Prerequisites

Must have the following installed on your machine:
- [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)
Note: Currently, the global.json pins the SDK version, so you may need to install the specific version of the SDK to build and run the application.

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
dotnet run
```

## Endpoints

- GET /events - Get a list of all events
- GET /health - Get the health status of the application