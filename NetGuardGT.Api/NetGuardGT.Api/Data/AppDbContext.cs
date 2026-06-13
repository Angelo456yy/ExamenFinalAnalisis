using Microsoft.EntityFrameworkCore;
using NetGuardGT.Api.Models;

namespace NetGuardGT.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<SitioRed> SitiosRed => Set<SitioRed>();
    public DbSet<Tecnico> Tecnicos => Set<Tecnico>();
    public DbSet<TecnicoEspecialidad> TecnicoEspecialidades => Set<TecnicoEspecialidad>();
    public DbSet<Incidente> Incidentes => Set<Incidente>();
    public DbSet<HistorialIncidente> HistorialIncidentes => Set<HistorialIncidente>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Tecnico>()
            .HasIndex(t => t.Correo)
            .IsUnique();

        modelBuilder.Entity<TecnicoEspecialidad>()
            .HasKey(te => new { te.TecnicoId, te.Especialidad });

        modelBuilder.Entity<TecnicoEspecialidad>()
            .HasOne(te => te.Tecnico)
            .WithMany(t => t.Especialidades)
            .HasForeignKey(te => te.TecnicoId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Incidente>()
            .HasOne(i => i.SitioRed)
            .WithMany(s => s.Incidentes)
            .HasForeignKey(i => i.SitioRedId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Incidente>()
            .HasOne(i => i.TecnicoAsignado)
            .WithMany(t => t.IncidentesAsignados)
            .HasForeignKey(i => i.TecnicoAsignadoId)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<HistorialIncidente>()
            .HasOne(h => h.Incidente)
            .WithMany(i => i.Historial)
            .HasForeignKey(h => h.IncidenteId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
