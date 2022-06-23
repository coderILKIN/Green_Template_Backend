using Green_Backen.Models;
using Microsoft.EntityFrameworkCore;

namespace Green_Backen.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }

        public DbSet<MainIcon> MainIcons { get; set; }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Contact> contacts { get; set; }
    }
}
