using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementRepository
{
    public interface IAdminProfileRepository
    {
        List<AdminProfile> GetAll();
        AdminProfile Get(int id);
        int Update(AdminProfile profile);
    }
}
