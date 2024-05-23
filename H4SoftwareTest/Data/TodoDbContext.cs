using H4SoftwareTest.Models;
using Microsoft.EntityFrameworkCore;

namespace H4SoftwareTest.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

        public DbSet<toDoList> Todos { get; set; }
        public DbSet<cpr> Cpr { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<toDoList>()
                .HasOne(t => t.cpr)
                .WithMany()
                .HasForeignKey(t => t.UserId);
        }
    }
}
