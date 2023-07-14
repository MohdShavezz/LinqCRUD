using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CName
    {
        public CName(List<Employee> Employees) {

            Console.WriteLine("enter UserID Id to get the Company Name: ");
            string userIdforName = Console.ReadLine();
            Validation.checkId(Employees, userIdforName);

            var comp = from i in Employees where i.ID == userIdforName select i;
                foreach (var i in comp)
                {
                    Console.WriteLine(i.CName);
                }
                Console.WriteLine("---------------------------");
          
        }
    }
}
