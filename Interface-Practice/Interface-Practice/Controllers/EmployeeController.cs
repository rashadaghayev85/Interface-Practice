using Interface_Practice.Models;
using Interface_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice.Controllers
{
    internal class EmployeeController
    {
        EmployeeService _employeeSevice;
        public EmployeeController()
        {
            _employeeSevice=new();
        } 
        public void GetAll()
        {
            var  employee= _employeeSevice.GetAll();
            foreach (var employe in employee)
            {
                Console.WriteLine(employe.Name+employe.Surname+employe.Email+employe.Birthday+employe.Age);
            }

        }
        public void GetById()
        {
            int? id = 100;
            //Console.WriteLine("id daxil edin");
           //int? id = int.Parse(Console.ReadLine());

            var result = _employeeSevice.GetById(id, _employeeSevice.GetAll());
          if (result.ErrorMessage is null)
            {
                Console.WriteLine(result.Employee.Name+result.Employee.Surname);
            }
            else 
            {
                Console.WriteLine(result.ErrorMessage);
            }
      
            
            

        }
        public void SearchByNameOrSurname()
        {
            Console.WriteLine("Axtardiginiz name ve ya surname daxil edin ");
            string result = Console.ReadLine();
            string name = result;
            string surname = result;    

           
           

           var response = _employeeSevice.SearchByNameOrSurname(_employeeSevice.GetAll(),name,surname);

            if (response.ErrorMessage is null)
            {
                
                Console.WriteLine(response.Employee.Name + response.Employee.Surname);
            }
          
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }
    }
}
