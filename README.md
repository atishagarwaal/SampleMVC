# SampleMVC

SampleMVC is a sample ASP.NET MVC web application demonstrating basic MVC concepts (controllers, views, models) and a small, opinionated project structure. The repository contains C#, Razor/HTML views, CSS, and JavaScript and is intended for learning and experimentation.

## .NET-focused README
This README includes concrete .NET examples (both Visual Studio / .NET Framework and .NET SDK / ASP.NET Core) so you can run and explore the project quickly.

---

## Contents
- C# code (controllers, models, project files)
- Views (Razor / .cshtml)
- Static assets (CSS, JavaScript)

## Prerequisites
- Visual Studio 2019 or 2022 (for full .NET Framework or Visual Studio tooling).
- .NET SDK 6.0 or later (for ASP.NET Core / .NET 6+ projects). Verify with:

```bash
dotnet --version
```

If the repository targets the full .NET Framework, open the `.sln` in Visual Studio. If it targets ASP.NET Core / .NET 5+, you can use the `dotnet` CLI.

To determine which framework the project targets, open a `.csproj` file and look for the `TargetFramework` / `TargetFrameworks` element. Examples:

- .NET 6: <TargetFramework>net6.0</TargetFramework>
- .NET Framework 4.8: <TargetFrameworkVersion>v4.8</TargetFrameworkVersion>

---

## Run locally — ASP.NET Core (dotnet CLI)
If the project is ASP.NET Core, run it with the .NET CLI:

1. Restore dependencies:

```bash
dotnet restore
```

2. Build:

```bash
dotnet build
```

3. Run (from the project folder or specify the csproj path):

```bash
# from the project folder
dotnet run

# or specifying the project file
dotnet run --project ./src/YourProject/YourProject.csproj
```

The app will print the listening URL(s), typically `https://localhost:5001` and `http://localhost:5000` unless overridden by launchSettings or environment variables.

Environment variables and launch profiles
- To use a specific environment (Development, Production):

```bash
export ASPNETCORE_ENVIRONMENT=Development  # Linux/macOS
setx ASPNETCORE_ENVIRONMENT Development     # Windows (PowerShell: $Env:ASPNETCORE_ENVIRONMENT = 'Development')
```

---

## Run in Visual Studio (full .NET Framework or ASP.NET Core)
1. Open the solution file (`.sln`) in Visual Studio.
2. Right-click the desired project and select "Set as Startup Project".
3. Press F5 to run with the debugger (IIS Express), or Ctrl+F5 to run without debugging.

If the project targets .NET Framework and uses IIS/IIS Express you will typically run it via Visual Studio's IIS Express launcher.

---

## Database / EF Core examples
If this project uses Entity Framework Core, here are common commands for migrations and applying them.

Install the EF Core CLI tool (if needed):

```bash
dotnet tool install --global dotnet-ef
```

Create a migration:

```bash
dotnet ef migrations add InitialCreate --project ./src/YourProject/YourProject.csproj --startup-project ./src/YourProject/YourProject.csproj
```

Apply migrations to the database:

```bash
dotnet ef database update --project ./src/YourProject/YourProject.csproj --startup-project ./src/YourProject/YourProject.csproj
```

Replace `./src/YourProject/YourProject.csproj` with the path to the web project's .csproj. If your solution uses a separate startup project (for example to configure DI or host), pass the correct `--startup-project`.

Connection strings
- Update connection strings in `appsettings.json` (ASP.NET Core) or `web.config` (full .NET Framework) to point to your local database.

---

## Tests
If the repository includes tests, run them with the .NET CLI:

```bash
# run tests in the solution
dotnet test

# run tests in a specific test project
dotnet test ./tests/YourTests/YourTests.csproj
```

Or use Visual Studio's Test Explorer.

---

## Common troubleshooting
- "Cannot find project or .csproj": make sure you run dotnet commands from a folder that contains the `.csproj` or pass the `--project` path.
- Missing EF Core tools: ensure `dotnet-ef` is installed as a global tool or use the package reference approach.
- SSL/TLS errors when running locally: trust the development certificate with `dotnet dev-certs https --trust`.

---

## Build and publish
- Build (release):

```bash
dotnet build -c Release
```

- Publish for deployment (example for Linux/x64):

```bash
dotnet publish -c Release -r linux-x64 --self-contained false -o ./publish
```

Adjust runtime identifier (RID) as needed. See the .NET docs for available RIDs.

---

## Contributing
Contributions are welcome. Typical contributions for a sample project include:
- Fixing typos or improving documentation
- Improving examples and comments
- Adding sample data or seed scripts

Please open an issue or a pull request with a clear description of your change.

## License
No license file is included in the repository. If you want this project to be open-source, add a `LICENSE` file (for example, the MIT license) or contact the repository owner for clarification.

---

*README added and updated with .NET examples by GitHub Copilot assistant.*
