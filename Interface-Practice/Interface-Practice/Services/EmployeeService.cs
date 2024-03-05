﻿using Interface_Practice.Helpers.Responses;
using Interface_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Practice.Services.Interfaces
{
    internal class EmployeeService : IEmployeeService
    {
        public Employee[] GetAll()
        {
            Employee employee1 = new()
            {
                Id = 1,
                Name = "Rashad",
                Surname = "Aghayev",
                Age = 21,
                Email = "rashad@gmail.com",
                Address = "Ordubad",
                Birthday = DateTime.Now.AddYears(-21),

            };

            Employee employee2 = new()
            {
                Id = 2,
                Name = "Rufat",
                Surname = "Ismayilov",
                Age = 22,
                Email = "rufat@gmail.com",
                Address = "Baki",
                Birthday = new DateTime(2003, 9, 4),

            };

            Employee employee3 = new()
            {
                Id = 3,
                Name = "Cavid",
                Surname = "Bashirov",
                Age = 30,
                Email = "cavid@gmail.com",
                Address = "Siyezen",
                Birthday = DateTime.Now.AddYears(-30),

            };

            Employee employee4 = new()
            {
                Id = 4,
                Name = "Amirastan",
                Surname = "Mereyev",
                Age = 33,
                Email = "Amirastan@gmail.com",
                Address = "Xezer",
                Birthday = DateTime.Now.AddYears(-33),

            };

            Employee employee5 = new()
            {
                Id = 5,
                Name = "Esgerxan",
                Surname = "Bayramov",
                Age = 27,
                Email = "esgerxan@gmail.com",
                Address = "Berde",
                Birthday = DateTime.Now.AddYears(-27),

            };

            Employee employee6 = new()
            {
                Id = 6,
                Name = "Behruz",
                Surname = "Aliyev",
                Age = 21,
                Email = "bahruz@gmail.com",
                Address = "Ordubad",
                Birthday = DateTime.Now.AddYears(-21),

            };

            Employee employee7 = new()
            {
                Id = 7,
                Name = "Rashad",
                Surname = "Aghayev",
                Age = 21,
                Email = "rashad@gmail.com",
                Address = "Ordubad",
                Birthday = DateTime.Now.AddYears(-21),

            };
            Employee employee8 = new()
            {
                Id = 8,
                Name = "Ismayil",
                Surname = "Ceferli",
                Age = 24,
                Email = "ismayil@gmail.com",
                Address = "Ehmedli",
                Birthday = DateTime.Now.AddYears(-24),

            };

            return new Employee[] { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8 };
        }

        public EmployeeResponse GetById(int? id, Employee[] employees)
        {

            if (id == null)
            {
                return new EmployeeResponse { ErrorMessage = "Id can't null" };
            }
            Employee? employee = employees.FirstOrDefault(m => m.Id == id);


            if (employee is null)
            {
                return new EmployeeResponse { ErrorMessage = "Employee not found" };
            }
            return new EmployeeResponse { Employee = employee };
        }

        public  EmployeeResponse SearchByNameOrSurname(Employee[] employees, string name, string surname)
        {
            if(name == null)
            {
                return new EmployeeResponse { ErrorMessage = "name or surname can't null" };
            }
            Employee?employee = employees.FirstOrDefault(m => m.Name.ToLower().Trim() ==name.ToLower().Trim()||m.Surname.ToLower().Trim() ==surname.ToLower().Trim());

            if (employee is null)
            {
                return new EmployeeResponse { ErrorMessage = "Employee not found" };
            }
            return new EmployeeResponse { Employee = employee };
        }
    }

}
