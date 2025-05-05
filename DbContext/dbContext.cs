using Microsoft.EntityFrameworkCore;
namespace Context
{
    public class dbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=E-commerce;Integrated Security=true;Encrypt=false");
        }

       
    }
}
