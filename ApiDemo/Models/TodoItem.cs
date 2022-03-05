using System;

namespace ApiDemo.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; } ="小希_"+new Random().Next(1,int.MaxValue).ToString();
        public bool IsComplete { get; set; } = new Random().Next(1, int.MaxValue)%2==0;
    }
}
