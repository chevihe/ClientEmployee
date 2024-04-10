using Employee.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Employee.API.PostModel
{
    public class EmployeePostModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Tz { get; set; }

        public DateTime StartWorkDate { get; set; }

        public Gender Gender { get; set; }

        public DateTime BirthDay { get; set; }

        public List<EmployeeRolePostModel> Roles { get; set; }
    }
}
