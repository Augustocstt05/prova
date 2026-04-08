using prova.Models;
using Microsoft.EntityFrameworkCore;

namespace prova.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Suas tabelas no banco de dados
        public DbSet<Personal> Personals { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Exercicios> Exercicios { get; set; }
        public DbSet<Treino> Treinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Isso evita erros de deleção em cascata se um Personal for removido
            modelBuilder.Entity<Aluno>()
                .HasOne(a => a.Personal)
                .WithMany(p => p.Alunos)
                .HasForeignKey(a => a.PersonalID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

