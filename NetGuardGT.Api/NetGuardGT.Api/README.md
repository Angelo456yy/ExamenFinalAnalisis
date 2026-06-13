# NetGuardGT.Api

Proyecto base de una API REST en ASP.NET Core 8 para gestionar incidentes de red de NetGuard GT.

## Contenido incluido

- Configuración de ASP.NET Core Web API.
- Swagger/OpenAPI.
- Entity Framework Core con SQLite.
- Enumeraciones de estados, severidades, especialidades, tipos de sitio y tipos de incidente.
- Modelos de sitio, técnico, especialidades, incidente e historial.
- `AppDbContext` con relaciones y correo único de técnicos.
- Endpoint de prueba `GET /api/health`.

## Crear la base de datos

Desde la carpeta que contiene `NetGuardGT.Api.csproj`:

```powershell
dotnet restore
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```

Swagger abrirá en `/swagger` cuando el entorno sea Development.

## Estructura

```text
NetGuardGT.Api/
├── BackgroundServices/
├── Controllers/
│   └── HealthController.cs
├── Data/
│   └── AppDbContext.cs
├── DTOs/
├── Enums/
│   ├── EspecialidadTecnica.cs
│   ├── EstadoIncidente.cs
│   ├── SeveridadIncidente.cs
│   ├── TipoIncidente.cs
│   └── TipoSitioRed.cs
├── Interfaces/
├── Models/
│   ├── HistorialIncidente.cs
│   ├── Incidente.cs
│   ├── SitioRed.cs
│   ├── Tecnico.cs
│   └── TecnicoEspecialidad.cs
├── Properties/
│   └── launchSettings.json
├── Services/
├── appsettings.Development.json
├── appsettings.json
├── NetGuardGT.Api.csproj
└── Program.cs
```
