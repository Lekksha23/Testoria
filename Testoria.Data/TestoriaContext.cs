using Microsoft.EntityFrameworkCore;
using Testoria.Data.Entities;

namespace Testoria.Data
{
    public class TestoriaContext : DbContext
    {
        public TestoriaContext(DbContextOptions<TestoriaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<Question> Questions { get; set; }
    }
}
