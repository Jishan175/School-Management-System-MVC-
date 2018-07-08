using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementRepository
{
    public class AdminProfileRepository : IAdminProfileRepository
    {
        SchoolDBContext context = new SchoolDBContext();
        public List<AdminProfile> GetAll()
        {
            return this.context.AdminProfiles.ToList();
        }
        public AdminProfile Get(int id)
        {
            return this.context.AdminProfiles.SingleOrDefault(p => p.ID == id);
        }

        public int Update(AdminProfile profile)
        {
            AdminProfile profileToUpdate = this.context.AdminProfiles.SingleOrDefault(p => p.ID == profile.ID);
            profileToUpdate.Username = profile.Username;
            profileToUpdate.Email = profile.Email;
            profileToUpdate.Password = profile.Password;
            return this.context.SaveChanges();
        }
    }
}
