using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementRepository
{
    public class EmployeeRepository
    {
        SchoolDBContext context = new SchoolDBContext();
        public List<Employee> GetAll()
        {
            return this.context.Employees.ToList();
        }

        public Employee Get(int id)
        {
            return this.context.Employees.SingleOrDefault(e => e.ID == id);

        }

        public int Insert(Employee employee)
        {
            int count = context.Employees.Where(x => x.ID != employee.ID).Count();
            employee.Username = "E" + (count + 1).ToString() + DateTime.Now.Year.ToString().Substring(2, 2).ToString();
            this.context.Employees.Add(employee);
            return this.context.SaveChanges();
        }

        public int Update(Employee employee)
        {
            Employee employeeToUpdate = this.context.Employees.SingleOrDefault(e => e.ID == employee.ID);
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.DOB = employee.DOB;
            employeeToUpdate.Religion = employee.Religion;
            employeeToUpdate.Gender = employee.Gender;
            employeeToUpdate.PhoneNo = employee.PhoneNo;
            employeeToUpdate.Email = employee.Email;
            employeeToUpdate.Address = employee.Address;
            employeeToUpdate.Designation = employee.Designation;
            employeeToUpdate.Password = employee.Password;
            employeeToUpdate.JoiningDate = employee.JoiningDate;
            employeeToUpdate.Salary = employee.Salary;
            return this.context.SaveChanges();
        }
        public int Delete(int id)
        {
            Employee employeeToDelete = this.context.Employees.SingleOrDefault(e => e.ID == id);
            if (employeeToDelete != null)
            {
                this.context.Employees.Remove(employeeToDelete);
            }
            return this.context.SaveChanges();
        }

    }
}
