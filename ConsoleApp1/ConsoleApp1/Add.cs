﻿using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Add
    {
        public Add(List<Employee> Employees)
        {
            Console.WriteLine("enter Name : ");
            string userNameAdd= Console.ReadLine();
            userNameAdd=Validation.checkName(userNameAdd);
            if (userNameAdd == "quit")
            {
                return;
            }

            Console.WriteLine("enter Department : ");
            string userDeptAdd= Console.ReadLine();
            userDeptAdd=Validation.checkName(userDeptAdd);
            if (userNameAdd == "quit")
            {
                return;
            }

            Console.WriteLine("enter Technology : ");
            string userTechAdd= Console.ReadLine();
            userTechAdd=Validation.checkNullorEmpty (userTechAdd);
            if (userNameAdd == "quit")
            {
                return;
            }

            Console.WriteLine("enter Company Name : ");
            string userCompAdd = Console.ReadLine();
            userCompAdd=Validation.checkNullorEmpty(userCompAdd);
            if (userNameAdd == "quit")
            {
                return;
            }


            Program.addEmployee(Employees, userNameAdd, userDeptAdd, userTechAdd, userCompAdd);
            Program.showEmployees(Employees); // show Employe Table
            Console.WriteLine("Added Successfully!!!");
            Console.WriteLine("---------------------------");
     
        }
    }
}
