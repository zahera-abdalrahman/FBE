using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }

        public string TaskTitle { get; set; }


        [DataType(DataType.Date)]
        public DateTime TaskStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime TaskDueDate { get; set; }

        public string TaskDescription { get; set; }

        public int ImportanceLevel { get; set; }

        public int EmployeeID { get; set; }

        public EmployeeList Employee { get; set; }
    }
}
