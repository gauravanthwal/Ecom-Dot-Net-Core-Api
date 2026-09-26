using Demo.Application.Interfaces;
using Demo.Domain.Dtos.Employee;
using Demo.Domain.Entities;
using Demo.Infrastructure.Persistency;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Infrastructure.Repositories
{
    public class EmployeeRepository(AppDbContext context): IEmployeeRepository
    {
        public async Task<List<EmployeeDto>> GetAllEmployeesAsync()
        {
            return await context.Employees.Select(x=> new EmployeeDto
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                Position = x.Position,
                DOB = x.DOB,
                PhoneNumber = x.PhoneNumber,
                CreatedDate = x.CreatedDate,
                UpdatedDate = x.UpdatedDate,
                City = x.City
            }).ToListAsync();
        }


        public async Task<EmployeeDto?> GetEmployeeById(int id)
        {
            var employee = await context.Employees.FindAsync(id);
            if (employee == null) return null;

            return new EmployeeDto
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Position = employee.Position,
                DOB = employee.DOB,
                PhoneNumber = employee.PhoneNumber,
                CreatedDate = employee.CreatedDate,
                UpdatedDate = employee.UpdatedDate,
                City = employee.City
            };
        }

        public async Task<string> AddEmployee(EmployeeDto emp)
        {
            var employee = new Employee
            {
                Name = emp.Name,
                Email = emp.Email,
                Position = emp.Position,
                DOB = emp.DOB,
                PhoneNumber = emp.PhoneNumber,
                CreatedDate = emp.CreatedDate,
                UpdatedDate = emp.UpdatedDate,
                City = emp.City
            };

            await context.Employees.AddAsync(employee);
            await context.SaveChangesAsync();
            return "Employee added successfully";
        }

        public async Task<string> DeleteEmployee(int id) 
        { 
            await context.Employees.Where(e => e.Id == id).ExecuteDeleteAsync();
            return "Employee deleted successfully";
        }

        public async Task<string> UpdateEmployee(EmployeeDto emp)
        {
            var existUser = await context.Employees.FindAsync(emp.Id);

            existUser.Name = string.IsNullOrWhiteSpace(emp.Name) ? existUser.Name : emp.Name;
            existUser.Email = string.IsNullOrWhiteSpace(emp.Email) ? existUser.Email : emp.Email;
            existUser.Position = string.IsNullOrWhiteSpace(emp.Position) ? existUser.Position : emp.Position;
            existUser.DOB = emp.DOB == default ? existUser.DOB : emp.DOB;
            existUser.PhoneNumber = string.IsNullOrWhiteSpace(emp.PhoneNumber) ? existUser.PhoneNumber : emp.PhoneNumber;
            existUser.UpdatedDate = DateTime.Now;
            existUser.City = emp.City;
            

            context.Employees.Update(existUser);
            await context.SaveChangesAsync();
            return "Employee updated successfully";
        }
    }
}
