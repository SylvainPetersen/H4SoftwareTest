using H4SoftwareTest.Models;
using Microsoft.EntityFrameworkCore;

namespace H4SoftwareTest.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

        public DbSet<ToDoList> Todos;
        public DbSet<cpr> Cpr;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoList>()
                .HasOne(t => t.cpr)
                .WithMany()
                .HasForeignKey(t => t.UserId);
        }
    }
}
