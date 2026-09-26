using Demo.Application.Interfaces;
using Demo.Domain.Dtos.Employee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Commands.EmployeeCommands
{
    public record AddEmployeeCommand(EmployeeDto Employee) : IRequest<string>;
    

    public class AddEmployeeCommandHandler(IEmployeeRepository employeeRepository): IRequestHandler<AddEmployeeCommand, string>
    {

        public Task<string> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return employeeRepository.AddEmployee(request.Employee);
        }
    }
}
