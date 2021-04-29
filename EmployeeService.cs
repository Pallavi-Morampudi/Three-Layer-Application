using BussinessObject;
using DataAcessLayer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class EmployeeService
    {
        public async Task<Employee> CreateEmployees(Employee employee)
        {
            EmployeeDao employeeDao = new EmployeeDao();

            var result = await employeeDao.CreateEmployees(employee);
            return result;
        }


        public Task CreateEmployees(List<Employee> employee)
        {
            throw new NotImplementedException();
        }
        public async Task<Employee> UpdateEmployees(Employee employee)
        {
            EmployeeDao empDao = new EmployeeDao();
            var result = await empDao.UpdateEmployee(employee);
            return result;
        }

        public async Task<Employee> GetEmployeeById(Employee employee)
        {
            EmployeeDao empDao = new EmployeeDao();
            var result = await empDao.GetEmployeeById(employee);
            return result;
        }

        public async Task<Employee> DeleteEmployeeByName(Employee employee)
        {
            EmployeeDao empDao = new EmployeeDao();
            var result = await empDao.DeleteEmployeeByName(employee);
            return result;
        }
    }
}
