using System.ComponentModel.DataAnnotations;

namespace RemindersPackage
{
    public class Reminder
    {
        [Required]
        public string RecipientEmail { get; set; }
        public int DaysBeforeDue { get; set; }
        [Range(0, 5)]
        public int NumberOfTimes{ get; set; }
    }
}