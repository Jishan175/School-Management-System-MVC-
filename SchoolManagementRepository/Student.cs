using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementRepository
{
    public class Student
    {
        public int ID { get; set; }
        public string Username { get; set; }
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Date of Birth is required")]
        public string DOB { get; set; }
        [Required(ErrorMessage = "Class is required")]
        public string ClassNumber { get; set; }
        [Required(ErrorMessage = "Roll is required")]
        public int Roll { get; set; }
        [Required(ErrorMessage = "Please select gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Religion is required")]
        public string Religion { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Fathername is required")]
        public string FatherName { get; set; }
        [Required(ErrorMessage = "Father Occupation is required")]
        public string FatherOccupation { get; set; }
        [Required(ErrorMessage = "Mothername is required")]
        public string MotherName { get; set; }
        [Required(ErrorMessage = "Mother occupation is required")]
        public string MotherOccupation { get; set; }
        [Required(ErrorMessage = "Phone no. is required")]
        public string GurdianPhoneNo { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Confirm Password required")]
        [CompareAttribute("Password", ErrorMessage = "Password doesn't match.")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Date is Required")]
        public string AdmissionDate { get; set; }

    }
}
