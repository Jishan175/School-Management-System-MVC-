using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementRepository
{
    
    public class LoginRepository:ILoginRepository
    {
        SchoolDBContext context = new SchoolDBContext();

        public Employee GetEmployee(string Username, string Password)
        {
            Employee employee = this.context.Employees.SingleOrDefault(e => e.Username ==Username && e.Password==Password );
            return employee;
        }

        public AdminProfile GetAdmin(string Username, string Password)
        {
            AdminProfile admin = this.context.AdminProfiles.SingleOrDefault(e => e.Username == Username && e.Password == Password);
            return admin;
        }

        public Student GetStudent(string Username, string Password)
        {
            Student student = this.context.Students.SingleOrDefault(e => e.Username == Username && e.Password == Password);
            return student;
        }
    }
}
