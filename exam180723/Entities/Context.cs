using Microsoft.EntityFrameworkCore;

namespace exam180723.Entities
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options): base(options) { }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
