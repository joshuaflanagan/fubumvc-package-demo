using System;
using System.ComponentModel.DataAnnotations;

namespace MyApplication.Actions.Todo
{
    public class Todo
    {
        [Required]
        public string Title { get; set; }
        [StringLength(Int32.MaxValue)]
        public string Notes { get; set; }
        public DateTime DueDateTime { get; set; }
        public bool HighPriority { get; set; }
    }
}