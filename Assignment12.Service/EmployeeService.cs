using Assignment12Aug.Repository.Entity;
using Assignment12Aug.Repository.Infrastructure;
using Assignment12Aug.Repository.Repository;
using System.Collections.Generic;

namespace Assignment12.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IUnitOfWork unitOfWork;

        public EmployeeService(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork)
        {
            this.employeeRepository = employeeRepository;
            this.unitOfWork = unitOfWork;
        }

        public IEnumerable<Employee> GetAllCustomers()
        {
            return employeeRepository.GetAll();
        }
    }

    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAllCustomers();
    }
}
