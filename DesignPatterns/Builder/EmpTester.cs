using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    internal class EmpTester
    {
        static void Main(string[] args)
        {
            try
            {
                EmployeeBuilder em = new EmployeeBuilder()
                .WithStaffNo("123").WithName("Kabelo", "Tlhape")
                .WithID("198741").Build();
                Console.WriteLine("=============OUTPUT====================");
                Console.WriteLine(em.ToString());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.Read();


        }
    }
}
