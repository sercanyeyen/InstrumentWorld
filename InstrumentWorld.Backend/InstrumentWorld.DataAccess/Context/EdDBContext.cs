using InstrumentWorld.DataAccess.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace InstrumentWorld.DataAccess.Repositories
{
    public class EdDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EdDB;Trusted_Connection=true;");
        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ChildCategory> ChildCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
    }

}