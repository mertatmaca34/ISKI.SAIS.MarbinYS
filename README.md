# ISKI.SAIS.MarbinYS

This solution contains a WinForms client and a backend implemented with CQRS and MediatR. The backend exposes a simple API for managing mail triggers.

## Projects

- **Api** - ASP.NET Core Web API that wires up the application and infrastructure layers.
- **Application** - Application layer using MediatR to handle commands and queries.
- **Infrastructure** - Entity Framework Core context and repository implementations.
- **Domain** - Plain entity definitions.
- **ISKI.Core** - Shared utilities and base abstractions.

## Building

Requires .NET 8 SDK.

```
dotnet build ISKI.SAIS.MarbinYS.sln
```

## Running the API

```
dotnet run --project Api/Api.csproj
```

When running in development mode the API serves an interactive Swagger UI at
`/swagger` for exploring and testing endpoints.

The API exposes endpoints for all domain entities. Currently implemented:

- `/api/mailtrigger` - full CRUD operations for triggers
- `/api/mailsettings` - list mail configuration records
- `/api/mailusers` - list registered users
- `/api/maillogs` - list mail send logs
- `/api/analogsensordata` - CRUD operations for analog sensor measurements

## Running the WinForms app

```
dotnet run --project WinUI/WinUI.csproj
```

The UI connects to the same backend to display and manage mail triggers using the `/api/mailtrigger` endpoint described above.
