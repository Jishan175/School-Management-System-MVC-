using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementRepository
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student Get(int id);
        int Insert(Student student);
        int Update(Student student);
        int Delete(int id);
    }
}
