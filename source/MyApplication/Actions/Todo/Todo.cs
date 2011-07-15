using System;

namespace MyApplication.Actions.Todo
{
    public class Todo
    {
        public string Title { get; set; }
        public string Notes { get; set; }
        public DateTime DueDateTime { get; set; }
        public bool HighPriority { get; set; }
    }
}