using Microsoft.EntityFrameworkCore;
using my_dotnet_webapi.Models;

namespace my_dotnet_webapi.Data
{
    using Microsoft.EntityFrameworkCore;
    
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }
    
        public DbSet<User> Users { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "John Doe", Email = "JohnDoe@test.com", Password = "JohnDoe12345" },
                new User { Id = 2, Name = "Mike Tyson", Email = "MikeTyson@test.com", Password = "MikeTyson12345" },
                new User { Id = 3, Name = "Jane Smith", Email = "JaneSmith@test.com", Password = "JaneSmith12345" },
                new User { Id = 4, Name = "Alice Johnson", Email = "AliceJohnson@test.com", Password = "AliceJohnson12345" },
                new User { Id = 5, Name = "Bob Brown", Email = "BobBrown@test.com", Password = "BobBrown12345" }
            );
        }
    }
}