using Microsoft.EntityFrameworkCore;

namespace CafeProject.Data
{
    public class Context : DbContext
    {
        public DbSet<About> AboutDbSet { get; set; }
        public DbSet<Address> AddressDbSet { get; set; }
        public DbSet<Banner> BannerDbSet { get; set; }
        public DbSet<Category> CategoryDbSet { get; set; }
        public DbSet<Chefs> ChefsDbSet { get; set; }
        public DbSet<Fotter> FotterDbSet { get; set; }
        public DbSet<Menu> MenuDbSet { get; set; }
        public DbSet<Reservations> ReservationbSet { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-5N8R6K8;database=CafeApp;integrated security=true");
        }
    }
}
