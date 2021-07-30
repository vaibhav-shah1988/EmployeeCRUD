using EmployeeCRUD.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCRUD.DAL.Repositories.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;
        public EmployeeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void AddEmployee(Employee employee)
        {
            try
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void DeleteEmployee(Employee employee)
        {
            try
            {
                _db.ChangeTracker.Clear();
                _db.Employees.Remove(employee);
                _db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }


        }

        public void EditEmployee(Employee employee)
        {
            try
            {
                _db.ChangeTracker.Clear();
                _db.Employees.Update(employee);
                _db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        public Employee GetEmployee(int Id)
        {
            return _db.Employees.Find(Id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _db.Employees;
        }
    }
}
