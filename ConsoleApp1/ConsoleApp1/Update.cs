using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Update
    {
        public Update(List<Employee> Employees)
        {
            Console.WriteLine("enter UserID to Update: ");
            string userID = Console.ReadLine();
            Validation.checkId(Employees, userID);

            Console.WriteLine("enter Name : ");
            string userName = Console.ReadLine();
            userName = Validation.checkName(userName);
            if (userName == "quit")
            {
                return;
            }

            Console.WriteLine("enter Department : ");
            string userDept = Console.ReadLine();
            userDept = Validation.checkName(userDept);
            if (userName == "quit")
            {
                return;
            }

            Console.WriteLine("enter Technology : ");
            string userTech = Console.ReadLine();
            userTech = Validation.checkNullorEmpty(userTech);
            if (userName == "quit")
            {
                return;
            }

            Console.WriteLine("enter Company Name : ");
            string userComp = Console.ReadLine();
            userComp = Validation.checkNullorEmpty(userComp);
            if (userName == "quit")
            {
                return;
            }
                foreach (var i in Employees.Where(emp => emp.ID == userID))
                {
                    i.Name = userName;
                    i.Dept = userDept;
                    i.Tech = userTech;
                    i.CName = userComp;
                }
                Program.showEmployees(Employees);
                Console.WriteLine("updated Successfully!!!");
                Console.WriteLine("---------------------------");
         

        }
    }
}
