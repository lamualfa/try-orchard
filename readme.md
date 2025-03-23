# Try Orchard

## Run

```bash
dotnet run --project TryOrchard.Server
```

## How this project was created?

1. `mkdir try-orchard`
2. `cd try-orchard`
3. `dotnet new sln -n TryOrchard`
4. `dotnet new occms -o TryOrchard.Server`
5. `dotnet sln add TryOrchard.Server`
6. `dotnet new ocmodulecms -o TryOrchard.Cms -A`
7. `dotnet sln add TryOrchard.Cms`
8. `dotnet add TryOrchard.Server reference TryOrchard.Cms`
9. Change Target Framework in [`TryOrchard.Server/TryOrchard.Server.csproj`](/TryOrchard.Server/TryOrchard.Server.csproj) to `net9.0`
10. Resolve outdated/incompatible package versions in `TryOrchard.Server` project
11. Add auto setup config in `TryOrchard.Server`
12. Change Target Framework in [`TryOrchard.Cms/TryOrchard.Cms.csproj`](/TryOrchard.Cms/TryOrchard.Cms.csproj) to `net9.0`
13. `dotnet run --project TryOrchard.Server`

## Directories

- [`TryOrchard.Server`](/TryOrchard.Server) - Orchard Core & Orchard CMS to running the server.
- [`TryOrchard.Cms`](/TryOrchard.Cms) - Orchard Module to handle Models, Migrations, Controllers, etc.
