using Microsoft.EntityFrameworkCore;

namespace AspMvcJwt.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Models.Person> Persons { get; set; }

        private string sqlConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PersonJwt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(sqlConnectionString); 
        }
    }
}
