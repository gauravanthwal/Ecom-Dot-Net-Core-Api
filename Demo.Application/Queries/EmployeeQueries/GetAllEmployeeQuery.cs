using Demo.Application.Interfaces;
using Demo.Domain.Dtos.Employee;
using MediatR;

namespace Demo.Application.Queries.EmployeeQueries
{
    public record GetAllEmployeeQuery() : IRequest<List<EmployeeDto>>;

    public class GetAllEmployeeQueryHandler(IEmployeeRepository employeeRepository): IRequestHandler<GetAllEmployeeQuery, List<EmployeeDto>>
    {

        public Task<List<EmployeeDto>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return employeeRepository.GetAllEmployeesAsync();
        }
    }

}
