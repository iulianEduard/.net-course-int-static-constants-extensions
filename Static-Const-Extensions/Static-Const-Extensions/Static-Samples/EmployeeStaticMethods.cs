using System;

namespace Static_Const_Extensions.Static_Samples
{
    public class EmployeeStaticMethods
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }

        public static double Multiplier = 0.01;

        public void RaiseSalary()
        {
            Salary += (Salary * Multiplier);
        }

        public void Display()
        {
            Console.WriteLine("*** Employee Data ***");
            Console.WriteLine($"Id: #{Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine(Environment.NewLine);
        }

        public static void RandomMultiplier()
        {
            /*
             * In a static method we cannot access class members that are not static
             */
            //Console.WriteLine("*** Employee Data From Static Salary ***");
            //Console.WriteLine($"Id: #{Id}");
            //Console.WriteLine($"Name: {Name}");
            //Console.WriteLine($"Salary: {Salary}");
            //Console.WriteLine(Environment.NewLine);

            var random = new Random();
            var newMultiplier = random.NextDouble();

            Console.WriteLine($"--> New multiplier: {newMultiplier}");

            Multiplier = newMultiplier;
        }
    }
}
