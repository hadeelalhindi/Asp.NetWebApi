using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication.Controllers
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class EmployeeController : ApiController
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, Name = "Hadeel", PhoneNumber = "1234567890" },
            new Employee { Id = 2, Name = "Mohammed", PhoneNumber = "0987654321" },
            new Employee { Id = 3, Name = "Alhindi", PhoneNumber = "5554443333" }
        };
        // GET api/employees
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // GET api/employees/5
        public Employee Get(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        // POST api/employees
        public void Post([FromBody] Employee employee)
        {
            employees.Add(employee);
        }

        // PUT api/employees/5
        public void Put(int id, [FromBody] Employee employee)
        {
            var index = employees.FindIndex(e => e.Id == id);
            employees[index] = employee;
        }

        // DELETE api/employees/5
        public void Delete(int id)
        {
            var employee = employees.FirstOrDefault(e => e.Id == id);
            employees.Remove(employee);
        }
    }
}
