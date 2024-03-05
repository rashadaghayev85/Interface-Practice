using Interface_Practice.Helpers.Responses;
using Interface_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice.Services.Interfaces
{
    public interface IEmployeeService
    {
        public Employee[] GetAll();
        public EmployeeResponse GetById(int? id, Employee[] employees);
        public EmployeeResponse SearchByNameOrSurname(Employee[] employees,string name,string surname); 

    }
}
