using Employee.Core.Entities;

namespace Employee.API.PostModel
{
    public class EmployeeRolePostModel
    {
        public int RoleID { get; set; }
        public bool IsManagement { get; set; }
        public DateTime StartRoleDate { get; set; }
    }
}
