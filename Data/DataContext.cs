using ejercicioORM.Modelo;
using Microsoft.EntityFrameworkCore;

namespace ejercicioORM.Data
{
    public class DataContext : DbContext

    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)

        {

        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Categories> Categories { get; set; }

        public DbSet<Products> Products { get; set; }


    }
}
