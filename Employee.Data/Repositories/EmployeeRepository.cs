using Employee.Core.Entities;
using Employee.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data.Repositories
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly DataContext _context;

        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Employee_> GetAllActiveEmployees()
        {
            return _context.Employees.Where(e => e.IsDeleted == false).Include(e=>e.Roles).ThenInclude(r=>r.Role);
        }

        public IEnumerable<Employee_> GetAllArcivesEmployees()
        {
            return _context.Employees.Where(e => e.IsDeleted == true).Include(e => e.Roles).ThenInclude(r => r.Role);
        }

        public Employee_ GetEmployeeById(int id)
        {
            return _context.Employees.Include(e => e.Roles).ThenInclude(r => r.Role).FirstOrDefault(e=>e.Id==id);
        }

        public Employee_ AddEmployee(Employee_ employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return _context.Employees.Include(e => e.Roles).ThenInclude(r => r.Role).FirstOrDefault(e => e.Id == employee.Id);
        
         }

        public Employee_ UpdateEmployee(int id,Employee_ employee)
        {
            var existingEmployee = _context.Employees.Include(e => e.Roles).ThenInclude(r => r.Role).First(e => e.Id == id);
            if (existingEmployee != null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Tz = employee.Tz;
                existingEmployee.StartWorkDate = employee.StartWorkDate;
                existingEmployee.BirthDay = employee.BirthDay;
                existingEmployee.Gender= employee.Gender;
                existingEmployee.Roles = employee.Roles;
            }
            _context.SaveChanges();
            return _context.Employees.Include(e => e.Roles).ThenInclude(r => r.Role).FirstOrDefault(e => e.Id == employee.Id);
        }

        public void ChangeEmployeeState(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employee.IsDeleted = !employee.IsDeleted;
            }
            _context.SaveChanges();
        }
    }
}



