using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementRepository
{
    public class Employee
    {
        public int ID { get; set; }
        public string Username { get; set; }
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Date of Birth is required")]
        public string DOB { get; set; }
        [Required(ErrorMessage = "Please select Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Religion is required")]
        public string Religion { get; set; }
        [Required(ErrorMessage = "Designation is required")]
        public string Designation { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone No is required")]
        public string PhoneNo { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Confirm Password required")]
        [CompareAttribute("Password", ErrorMessage = "Password doesn't match.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please Enter Joining Date ")]
        public string JoiningDate { get; set; }
        [Required(ErrorMessage = "Salary is required")]
        public double Salary { get; set; }

    }
}
