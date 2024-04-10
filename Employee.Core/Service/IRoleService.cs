using Employee.Core.Entities;
using Employee.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Service
{
    public interface IRoleService
    {
        public IEnumerable<Role> GetAllRole();
        public Role GetRoleById(int id);
        public void AddRole(Role role);
        public void UpdateRole(int id,Role role);
        public void DeleteRole(int id);
    }
}
