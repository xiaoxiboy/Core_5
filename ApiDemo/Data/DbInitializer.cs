using ApiDemo.Models;
using System.Linq;

namespace ApiDemo.Data
{
    public static class DbInitializer
    {
        public static void Initialize(TodoContext context)
        {
            context.Database.EnsureCreated();

            // 是否有元素
            if (context.TodoItems.Any())
            {
                return;   // DB has been seeded
            }

            var TodoItems = new TodoItem[]
            {
            new TodoItem(),
            new TodoItem(),
            new TodoItem(),
            new TodoItem(),
            new TodoItem(),
            new TodoItem(),
            };
            foreach (TodoItem s in TodoItems)
            {
                context.TodoItems.Add(s);
            }
            context.SaveChanges();

        }
    }
}
