using Employee.Core.Entities;
using Employee.Core.Repositories;
using Employee.Core.Service;
using Employee.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Service
{
    public class RoleService: IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public IEnumerable<Role> GetAllRole()
        {
            return _roleRepository.GetAllRoles();
        }

        public Role GetRoleById(int id)
        {
            return _roleRepository.GetRoleById(id);
        }

        public void AddRole(Role role)
        {
            _roleRepository.AddRole(role);
        }

        public void UpdateRole(int id,Role role)
        {
            _roleRepository.UpdateRole(id,role);
        }

        public void DeleteRole(int id)
        {
            _roleRepository.DeleteRole(id);
        }
    }
}

