using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Delete
    {
        public Delete(List<Employee> Employees)
        {

            Console.WriteLine("enter UserID to Delete: ");
            string userIdDel = Console.ReadLine();
            Validation.checkId(Employees, userIdDel);
            Employees.RemoveAll(e => e.ID == userIdDel);
            Console.WriteLine("ID :{0} Deleted sucessfully!!!", userIdDel);
            Console.WriteLine("---------------------------");
            Program.showEmployees(Employees);

        }
    }
}
