using System;

namespace Static_Const_Extensions.Const_Read_Samples
{
    public class EmployeeReadonly
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public readonly double multiplier = 0.1;

        public EmployeeReadonly(double newMultiplier)
        {
            multiplier = newMultiplier;
        }

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
