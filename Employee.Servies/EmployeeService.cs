using Employee.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Core.Entities;
using Employee.Data.Repositories;
using Employee.Core.Repositories;

namespace Employee.Servies
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee_> GetAllActiveEmployees()
        {
            return _employeeRepository.GetAllActiveEmployees();

        }

        public IEnumerable<Employee_> GetAllArcivesEmployees()
        {
            return _employeeRepository.GetAllArcivesEmployees();

        }

        public Employee_ GetEmployeeById(int id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        public Employee_ AddEmployee(Employee_ employee)
        {
           return _employeeRepository.AddEmployee(employee);
        }

        public Employee_ UpdateEmployee(int id,Employee_ employee)
        {
            return _employeeRepository.UpdateEmployee(id,employee);
        }

        public void DeleteAndRescueEmployee(int id)
        {
            _employeeRepository.ChangeEmployeeState(id);
        }
    }
}





