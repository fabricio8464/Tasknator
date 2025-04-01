using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Tasknator.Entities;


namespace Tasknator.Helper
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TaskEntity> TaskEntity { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TaskEntity>().ToTable("tasks", "mn_api"); // Garante que busca no esquema correto
        //}
    }

}
