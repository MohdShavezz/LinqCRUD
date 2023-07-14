using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class Employee
    {
        public string ID = Guid.NewGuid().ToString("N").Substring(0, 8);
        public string Name;
        public string Dept;
        public string Tech;
        public string CName;
        public Employee(string name, string dept, string tech, string cname)
        {
            Name = name;
            Dept = dept;
            Tech = tech;
            CName = cname;
        }
    }
    public class Program
    {
        public static void showEmployees(List<Employee> Employees)
        {
            foreach (var i in Employees)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", i.ID, i.Name, i.Dept, i.Tech, i.CName);
            }
        }

        public static void addEmployee(List<Employee> Employees, string name, string dep, string tech, string cname)
        {
            Employees.Add(new Employee(name, dep, tech, cname));
        }

        public static void Main(string[] args)
        {
            var Employees = new List<Employee>{

            new Employee("shavez","IT","DotNet","AspireFox"),
            new Employee("sharad","Dev","Devops","Google"),
            new Employee("amit","IT","Cloud","Amazon"),
            new Employee("sahil","Sales","Shopify","Unknown"),
            new Employee("rehan","IT","Analyst","Google"),

          };


            // Print Employees Table
            Program.showEmployees(Employees);
            Console.WriteLine("---------------------------");
            Console.ReadLine();


            while (true)
            {
                Console.WriteLine("Add : press a");
                Console.WriteLine("Update : press u");
                Console.WriteLine("Delete : press d");
                Console.WriteLine("Show CompanyName by Emp Id : press n");
                Console.WriteLine("Show Employees GroupBy Company : press s");
                Console.WriteLine("Exit : press e");
                string usrChoice = Console.ReadLine();
                if (usrChoice == "a")
                {
                    // add Employee
                    new Add(Employees);
                }
                else if (usrChoice == "u")
                {
                    // Update Row
                    new Update(Employees);
                }
                else if (usrChoice == "d")
                {
                    // Delete Row
                    new Delete(Employees);
                    Console.ReadLine();

                }
                else if (usrChoice == "n")
                {
                    // Compnay By Employee ID
                    new CName(Employees);
                }
                else if (usrChoice == "s")
                {
                    new Show(Employees);
                    Console.ReadLine();
                }
                else if (usrChoice == "e")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(  "invalid input");
                }
            }




        }
    }
}