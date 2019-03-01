using Microsoft.EntityFrameworkCore;
using TesteLucas.Models.EntityModel.Users;
using TesteLucas.Models.EntityModel.Tasks;

namespace TesteLucas.Infrastructure.Context
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Task> Tasks { get; set; }

        public Context(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Configure();
            modelBuilder.Entity<Task>().Configure();
        }
    }
}
