using EmployeeCRUD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.DAL.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();

        Employee GetEmployee(int Id);

        void AddEmployee(Employee employee);

        void EditEmployee(Employee employee);

        void DeleteEmployee(Employee employee);


    }
}
