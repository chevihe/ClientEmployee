using Employee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.DTOs
{
    public class EmployeeRoleDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int RoleID { get; set; }
        public DateTime StartRoleDate { get; set; }
    }
}
