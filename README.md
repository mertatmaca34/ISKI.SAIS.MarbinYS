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

The API exposes `/api/mailtrigger` for creating and listing mail triggers.
