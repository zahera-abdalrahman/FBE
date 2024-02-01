using System.ComponentModel.DataAnnotations;
using static Humanizer.On;

namespace Employee.Models
{
    public class Feedback
    {
        [Key]
        public int FeedbackId { get; set; }

        public string SenderName { get; set; }

        public string SenderEmail { get; set; }

        public string FeedbackContent { get; set; }

        public int EmployeeID { get; set; }

        public EmployeeList Employee { get; set; }
    }
}
