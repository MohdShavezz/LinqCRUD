using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Show
    {
        public Show(List<Employee> Employees)
        {
            var DistinctComapanies = Employees.Select(std => std.CName)
                       .Distinct().ToList();
            foreach (var i in DistinctComapanies)
            {
                var empName = Employees.Where(e => e.CName == i)
                              .Select(e => new { Name = e.Name, Company = e.CName });

                foreach (var j in empName)
                {
                    Console.WriteLine(j.Company + " " + j.Name);
                }
            }
            Console.WriteLine("---------------------------");
        }
    }
}
