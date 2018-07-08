using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementRepository
{
    public interface ILoginRepository
    {
        Employee GetEmployee(string username, string password);
        Student GetStudent(string username, string password);
        AdminProfile GetAdmin(string username, string password);
    }
}
