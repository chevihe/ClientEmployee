using Employee.Core.Entities;
using Employee.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Service
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee_> GetAllActiveEmployees();
        public IEnumerable<Employee_> GetAllArcivesEmployees();
        public Employee_ GetEmployeeById(int id);
        public Employee_ AddEmployee(Employee_ employee);
        public Employee_ UpdateEmployee(int id, Employee_ employee);
        public void DeleteAndRescueEmployee(int id);
    }
}
