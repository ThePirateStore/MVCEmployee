using System;
using System.ComponentModel.DataAnnotations;

namespace MVCEmployee.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Department { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public String EndDate { get; set; }

        [Display(Name = "Employment Status")]
        public string EmploymentStatus { get; set; }

        [Display(Name = "Favorite Color")]
        public string FavoriteColor { get; set; }

        public string Address { get; set; }
        public string Shift { get; set; }
        public string Manager { get; set; }
        public string Image { get; set; }
    }
}
