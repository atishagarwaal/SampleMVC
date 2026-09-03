# SampleMVC

## 1. Overview

SampleMVC is a small ASP.NET Core web application (Razor / MVC) targeting .NET 10. It demonstrates basic controllers, views, models, and an EF Core DbContext.

## 2. Description

The project includes:
- Controllers and Razor views for a simple blog
- An EF Core DbContext (BlogDataContext) configured to use an in-memory database by default
- Static assets in wwwroot

This repository is intended as a minimal sample to explore ASP.NET Core web app structure and local development.

## 3. Pre-requisites

- .NET 10 SDK (install from https://dotnet.microsoft.com)
- Optional: Visual Studio 2022/2026 or another IDE that supports .NET 10
- Git (optional)

Verify your .NET SDK with:

```powershell
dotnet --version
```

## 4. Build and Run

From the repository root (where SampleMVC.sln is located) using the .NET CLI:

1. Restore packages

```powershell
dotnet restore
```

2. Build the solution

```powershell
dotnet build
```

3. Run the web application

```powershell
dotnet run --project SampleMVC/SampleMVC.csproj
```

The console will show the listening URL(s) (for example https://localhost:5001). Open that URL in your browser.

To run from Visual Studio: open SampleMVC.sln, set the web project as the startup project and press F5.

Notes:
- The project is configured to use an in-memory EF Core database by default. To switch to a persistent provider (e.g., SQL Server), update Startup.cs and appsettings.json.
- Remove or update connection strings in appsettings.json if you change the provider.