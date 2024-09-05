using Company.Data.Models;
using Company.Repository.Interfaces;
using Company.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Employee employee)
        {
            var mappedEmployee = new Employee
            {
                Name = employee.Name,
                Age = employee.Age,
                Address = employee.Address,
                Salary = employee.Salary,
                Email = employee.Email,
                PhoneNumber = employee.PhoneNumber,
                HiringDate = employee.HiringDate,
                CreateAt = DateTime.Now

            };

            _unitOfWork.EmployeeRepository.Add(mappedEmployee);

           // _unitOfWork.Complete();
        }

        public void Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            var employees = _unitOfWork.EmployeeRepository.GetAll();
            return employees;
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployeeByName(string name)
         => _unitOfWork.EmployeeRepository.GetEmployeeByName(name);

        public void Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
