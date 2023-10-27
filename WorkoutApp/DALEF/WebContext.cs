using DALInterfaces.Models;
using Microsoft.EntityFrameworkCore;

namespace DALEF
{
    public class WebContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public WebContext() { }

        public WebContext(DbContextOptions<WebContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(StartUp.ConnectionString);
        }
    }
}
