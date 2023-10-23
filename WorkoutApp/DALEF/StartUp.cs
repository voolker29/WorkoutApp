using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DALEF
{
    public class StartUp
    {
        public const string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Workout;Integrated Security=True;Pooling=False";

        public void RegisterDbContext(IServiceCollection services)
        {
            services.AddDbContext<WebContext>(op => op
                .UseLazyLoadingProxies()
                .UseSqlServer(ConnectionString));
        }
    }
}
