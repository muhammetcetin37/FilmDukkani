using Film.Entities;
using Microsoft.EntityFrameworkCore;

namespace Film.DAL.Contexts
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }
        public SqlDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=FilmDukkani;Trusted_connection=true");
        }

        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Filmler> Filmler { get; set; }
        public DbSet<FilmlerKategori> FilmlerKategori { get; set; }
        //public DbSet<Ilce> Ilceler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Paket> Paketler { get; set; }
        //public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Tedarikci> Tedarikciler { get; set; }
        public DbSet<Uyeler> Uyeler { get; set; }
        //public DbSet<Sepet> Sepet { get; set; }
        public DbSet<Kargo> Kargo { get; set; }


    }
}
