using SchoolManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementRepository
{
    
    public class StudentRepository : IStudentRepository
    {

        SchoolDBContext context = new SchoolDBContext();
        public List<Student> GetAll()
        {
            return this.context.Students.ToList();
        }

        public Student Get(int id)
        {
            return this.context.Students.SingleOrDefault(s => s.ID == id);

        }

        public int Insert(Student student)
        {
            int count = context.Students.Where(x => x.ID != student.ID).Count();
            student.Username = "S"+(count + 1).ToString() + student.ClassNumber.ToString() + DateTime.Now.Year.ToString().Substring(2, 2).ToString();
            this.context.Students.Add(student);
            return this.context.SaveChanges();
        }

        public int Update(Student student)
        {
            Student studentToUpdate = this.context.Students.SingleOrDefault(s => s.ID == student.ID);
            studentToUpdate.Username = student.Username;
            studentToUpdate.FirstName = student.FirstName;
            studentToUpdate.LastName = student.LastName;
            studentToUpdate.DOB = student.DOB;
            studentToUpdate.FatherName = student.FatherName;
            studentToUpdate.FatherOccupation = student.FatherOccupation;
            studentToUpdate.MotherName = student.MotherName;
            studentToUpdate.MotherOccupation = student.MotherOccupation;
            studentToUpdate.ClassNumber = student.ClassNumber;
            studentToUpdate.Roll = student.Roll;
            studentToUpdate.Religion = student.Religion;
            studentToUpdate.Gender = student.Gender;
            studentToUpdate.GurdianPhoneNo = student.GurdianPhoneNo;
            studentToUpdate.Email = student.Email;
            studentToUpdate.Address = student.Address;
            studentToUpdate.Password = student.Password;
            studentToUpdate.AdmissionDate = student.AdmissionDate;
            return this.context.SaveChanges();
        }
        public int Delete(int id)
        {
            Student studentToDelete = this.context.Students.SingleOrDefault(s => s.ID == id);
            if (studentToDelete != null)
            {
                this.context.Students.Remove(studentToDelete);
            }
            return this.context.SaveChanges();
        }
    }
}
