using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Const_Extensions.Const_Read_Samples
{
    public class EmployeeConst
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public const double multiplier = 0.01;

        public void RaiseSalary()
        {
            Salary += (Salary * multiplier);
        }

        public void Display()
        {
            Console.WriteLine("*** Employee Data ***");
            Console.WriteLine($"Id: #{Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
