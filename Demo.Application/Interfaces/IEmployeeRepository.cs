using Demo.Domain.Dtos.Employee;
using Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        public Task<List<EmployeeDto>> GetAllEmployeesAsync();

        public Task<EmployeeDto?> GetEmployeeById(int id);

        public Task<string> AddEmployee(EmployeeDto emp);

        public Task<string> DeleteEmployee(int id);

        public Task<string> UpdateEmployee(EmployeeDto emp);
    }
}
