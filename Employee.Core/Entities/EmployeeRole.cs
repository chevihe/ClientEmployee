using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Entities
{

    public class EmployeeRole
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int RoleID { get; set; }
        public Role Role { get; set; }
        public DateTime StartRoleDate { get; set; }
    }
}
