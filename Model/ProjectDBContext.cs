using Microsoft.EntityFrameworkCore;
using Model.DomainModel;

namespace Model
{
    public class ProjectDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=FinalProjectDb;Integrated Security=True;MultipleActiveResultSets=True;Encrypt=False");
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
