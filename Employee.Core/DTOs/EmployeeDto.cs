using Employee.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.DTOs
{

    public class EmployeeDto
    {
        
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Tz { get; set; }

        public DateTime StartWorkDate { get; set; }

        public Gender Gender { get; set; }

        public DateTime BirthDay { get; set; }

        public List<EmployeeRole> Roles { get; set; }
    }
}
