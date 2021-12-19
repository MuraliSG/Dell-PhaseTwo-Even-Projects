using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCRepositoryDependencyInjectionApplication.Models
{
    interface IEmployeeRepository
    {
        IList<Employee> GetEmployees();
        Employee GetEmployeeById(int employeeId);
        void AddEmplyee(Employee employee);
    }
}
