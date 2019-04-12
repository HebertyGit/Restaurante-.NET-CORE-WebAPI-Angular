using Microsoft.EntityFrameworkCore;
using RestauranteWeb.API.Model;

namespace RestauranteWeb.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}
        
        public DbSet<Prato> Prato { get; set; }

    }
}