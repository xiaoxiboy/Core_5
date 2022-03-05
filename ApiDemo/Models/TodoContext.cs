using ApiDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiDemo.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /// 指定表名
            modelBuilder.Entity<TodoItem>().ToTable("TodoItem");
        }
    }
}