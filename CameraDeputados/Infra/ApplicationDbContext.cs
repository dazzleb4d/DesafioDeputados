using CameraDeputados.Models;
using Microsoft.EntityFrameworkCore;

namespace CameraDeputados.Infra;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Despesa> Despesas { get; set; }
    public DbSet<Deputado> Deputados { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Configuração da entidade Deputado
        modelBuilder.Entity<Deputado>()
            .HasKey(d => d.Id);

        // Configuração da entidade Despesa
        modelBuilder.Entity<Despesa>()
            .HasKey(d => d.Id);

        modelBuilder.Entity<Despesa>()
            .HasOne(d => d.Deputado)
            .WithMany(dp => dp.Despesas) // Relacionamento 1:N
            .HasForeignKey(d => d.DeputadoId); // Chave estrangeira
    }
}