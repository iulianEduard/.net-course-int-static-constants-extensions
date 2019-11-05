using Static_Const_Extensions.Const_Read_Samples;
using Static_Const_Extensions.Extensions_Samples;
using Static_Const_Extensions.Static_Samples;
using System;

namespace Static_Const_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            CostReadOnlyExample();
        }

        static void StaticExample()
        {
            var employee = new Employee
            {
                Id = 1,
                Name = "Jon Snow",
                Salary = 2000.0
            };

            employee.Display();
            employee.RaiseSalary();

            Console.WriteLine("--> Display data after raise");

            employee.Display();

            Employee.Multiplier = 0.02;

            var employee2 = new Employee
            {
                Id = 2,
                Name = "Danny",
                Salary = 2000.0
            };

            employee2.RaiseSalary();

            Console.WriteLine("--> Display data after raise");
            employee2.Display();

            Console.ReadKey();
        }

        static void StaticMethodsExample()
        {
            var employeeBran = new EmployeeStaticMethods
            {
                Id = 1,
                Name = "Bran",
                Salary = 100.0
            };

            employeeBran.RaiseSalary();
            employeeBran.Display();

            EmployeeStaticMethods.RandomMultiplier();

            var employeeHodor = new EmployeeStaticMethods
            {
                Id = 2,
                Name = "Hodor",
                Salary = 200.0
            };

            employeeHodor.RaiseSalary();
            employeeHodor.Display();

            Console.ReadKey();
        }

        static void StaticClassExample()
        {
            var employeeSansa = new EmployeeStaticMethods
            {
                Id = 1,
                Name = "Sansa",
                Salary = 100.0
            };

            employeeSansa.Salary = EmployeeStaticClass.RaiseEmployeeSalary(employeeSansa.Salary);
            employeeSansa.Display();

            EmployeeStaticClass.RandomMultiplier();

            employeeSansa.Salary = EmployeeStaticClass.RaiseEmployeeSalary(employeeSansa.Salary);
            employeeSansa.Display();

            Console.ReadKey();
        }

        static void ExtenstionExample()
        {
            var employeeGreyWorm = new Employee
            {
                Id = 1,
                Name = "g",
                Salary = 100.0
            };

            employeeGreyWorm.Name = employeeGreyWorm.Name.ToNameToUpperCase();

            employeeGreyWorm.Display();

            Console.ReadKey();
        }

        static void ConstExample()
        {
            var employeeTyrion = new EmployeeConst
            {
                Id = 1,
                Name = "Tyrion",
                Salary = 200.0
            };

            /*
             * Even though mutiplier is set as public we cannot access it like this
             */
            // employeeTyrion.multiplier

            Console.WriteLine($"Multiplier for salary is: {EmployeeConst.multiplier}");
            
            employeeTyrion.RaiseSalary();
            employeeTyrion.Display();

            /*
             * Const means that once we provide a value, we cannot change it anymore
             */
            // EmployeeConst.multiplier = 21;

            Console.ReadKey();
        }

        static void ReadonlyExample()
        {
            var employeeNed = new EmployeeReadonly(0.1)
            {
                Id = 1,
                Name = "Ned",
                Salary = 100
            };

            employeeNed.RaiseSalary();
            employeeNed.Display();

            var employeeRobb = new EmployeeReadonly(0.01)
            {
                Id = 2,
                Name = "Robb Stark",
                Salary = 100
            };

            employeeRobb.RaiseSalary();
            employeeRobb.Display();

            Console.ReadKey();
        }

        static void CostReadOnlyExample()
        {
            var sampleMethod = new MyStringTestClassSample();
            sampleMethod.SampleMethod();

            Console.ReadKey();
        }
    }
}
