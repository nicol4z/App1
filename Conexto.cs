using System;
using Microsoft.EntityFrameworkCore;

public class Conexto: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-MIBUEOA;Database=SistemaProyecto;Trusted_Connection=True");
    }

    public DbSet<Proyecto> Proyectos { get; set; }

    public DbSet<Tarea> Tareas { get; set; }

    public DbSet<Material>Materiales { get; set; }

    public DbSet<ConsumoMaterial> ConsumoMateriales { get; set; } 
}