using HttpStatusCode.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HttpStatusCode.Infrastructure.Contex
{
    public class SqlDbcontext : DbContext
    {
        public SqlDbcontext(DbContextOptions<SqlDbcontext> options) : base(options)
        {

        }

        public SqlDbcontext()
        {

        }

        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FilmDukkani;Trusted_connection=true");
        }
    }
}