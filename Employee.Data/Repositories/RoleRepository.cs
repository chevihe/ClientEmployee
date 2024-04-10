using Employee.Core.Entities;
using Employee.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data.Repositories
{
    public class RoleRepository: IRoleRepository
    {
        private readonly DataContext _context;

        public RoleRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return _context.Roles;
        }

        public Role GetRoleById(int id)
        {
            return _context.Roles.Find(id);
        }

        public void AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
        }

        public void UpdateRole(int id,Role role)
        {
            var existingRole = _context.Roles.Find(id);
            if (existingRole != null)
            {
               existingRole.Name=role.Name;
            }
            _context.SaveChanges();
        }

        public void DeleteRole(int id)
        {
            var role = _context.Roles.FirstOrDefault(r => r.RoleID == id);
            if (role != null)
            {
                _context.Roles.Remove(role);
            }
            _context.SaveChanges();
        }
    }
}

