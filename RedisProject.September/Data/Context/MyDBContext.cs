using Microsoft.EntityFrameworkCore;
using RedisProject.September.Data.Entities;

namespace RedisProject.September.Data.Context
{
    public class MyDBContext : DbContext
    {
        public MyDBContext()
        {

        }
        public MyDBContext(DbContextOptions opt) : base(opt)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=.;Database=AdventureWorks2016;integrated security=true;");
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Production> Productions { get; set; }
    }
}
