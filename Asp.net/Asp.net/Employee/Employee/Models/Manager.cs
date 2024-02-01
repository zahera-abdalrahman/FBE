using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Employee.Models
{
    public class Manager 
    {
        [Key]
        public int ManagerId { get; set; }

        public string ManagerName { get; set; }
    }
}
