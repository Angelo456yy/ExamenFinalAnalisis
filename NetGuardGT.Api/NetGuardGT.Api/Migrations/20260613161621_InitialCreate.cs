using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NetGuardGT.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SitiosRed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Ubicacion = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SitiosRed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreCompleto = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Correo = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    Telefono = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Activo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                    Severidad = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false),
                    SitioRedId = table.Column<int>(type: "INTEGER", nullable: false),
                    TecnicoAsignadoId = table.Column<int>(type: "INTEGER", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaLimiteSla = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaAsignacion = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FechaResolucion = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FechaCierre = table.Column<DateTime>(type: "TEXT", nullable: true),
                    SolucionAplicada = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true),
                    Escalado = table.Column<bool>(type: "INTEGER", nullable: false),
                    FechaEscalamiento = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidentes_SitiosRed_SitioRedId",
                        column: x => x.SitioRedId,
                        principalTable: "SitiosRed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidentes_Tecnicos_TecnicoAsignadoId",
                        column: x => x.TecnicoAsignadoId,
                        principalTable: "Tecnicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "TecnicoEspecialidades",
                columns: table => new
                {
                    TecnicoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Especialidad = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TecnicoEspecialidades", x => new { x.TecnicoId, x.Especialidad });
                    table.ForeignKey(
                        name: "FK_TecnicoEspecialidades_Tecnicos_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "Tecnicos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistorialIncidentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IncidenteId = table.Column<int>(type: "INTEGER", nullable: false),
                    EstadoAnterior = table.Column<int>(type: "INTEGER", nullable: true),
                    EstadoNuevo = table.Column<int>(type: "INTEGER", nullable: false),
                    Accion = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Detalle = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    Responsable = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    FechaCambio = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistorialIncidentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistorialIncidentes_Incidentes_IncidenteId",
                        column: x => x.IncidenteId,
                        principalTable: "Incidentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistorialIncidentes_IncidenteId",
                table: "HistorialIncidentes",
                column: "IncidenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidentes_SitioRedId",
                table: "Incidentes",
                column: "SitioRedId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidentes_TecnicoAsignadoId",
                table: "Incidentes",
                column: "TecnicoAsignadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Tecnicos_Correo",
                table: "Tecnicos",
                column: "Correo",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistorialIncidentes");

            migrationBuilder.DropTable(
                name: "TecnicoEspecialidades");

            migrationBuilder.DropTable(
                name: "Incidentes");

            migrationBuilder.DropTable(
                name: "SitiosRed");

            migrationBuilder.DropTable(
                name: "Tecnicos");
        }
    }
}
