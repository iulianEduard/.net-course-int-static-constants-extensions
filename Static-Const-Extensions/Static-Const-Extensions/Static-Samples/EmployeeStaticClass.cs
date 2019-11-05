using System;

namespace Static_Const_Extensions.Static_Samples
{
    public static class EmployeeStaticClass
    {
        /*
         * We cannot have non-static class members in a class decorated with static
         */
        //public int Id { get; set; }

        //public void Display()
        //{

        //}

        private static double _multiplier = 0.1;

        public static void RandomMultiplier()
        {
            var random = new Random();
            var newMultiplier = random.NextDouble();

            _multiplier = newMultiplier;
        }

        public static double RaiseEmployeeSalary(double baseSalary)
        {
            baseSalary += (baseSalary * (1 / _multiplier));

            return baseSalary;
        }
    }
}
