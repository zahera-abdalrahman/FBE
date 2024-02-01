using System.ComponentModel.DataAnnotations;
using static Humanizer.On;

namespace Employee.Models
{
    public class EmployeeList
    {

        [Key]
        public int EmployeeID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public string PhoneNumber { get; set; }

        public string NationalID { get; set; }

        public string Nationality { get; set; }

        public string MaritalStatus { get; set; }
   
        public string PersonalPhoto { get; set; }


        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set;}

        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public int ManagerId { get; set; }

        public Manager Manager { get; set; }
    }
}
