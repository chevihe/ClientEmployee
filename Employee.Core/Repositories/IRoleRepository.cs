using Employee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories
{
    public interface IRoleRepository
    {
        public IEnumerable<Role> GetAllRoles();
        public Role GetRoleById(int id);
        public void AddRole(Role role);
        public void UpdateRole(int id,Role role);
        public void DeleteRole(int id);
    }
}
