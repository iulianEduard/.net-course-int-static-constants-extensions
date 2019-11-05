using System;

namespace Static_Const_Extensions.Extensions_Samples
{
    public static class StringExtensions
    {
        public static string ToNameToUpperCase(this string name)
        {
            if (name.Length < 1)
            {
                Console.WriteLine("Can't apply operation! Exiting...");
                return name;
            }

            var firstChar = name[0];
            if (!char.IsLetter(firstChar))
            {
                Console.WriteLine("Name must start with letter! Exiting");
                return name;
            }

            if (!char.IsUpper(firstChar))
            {
                Console.WriteLine("Update name to start with upper case");
                name = char.ToUpper(firstChar) + name.Substring(1, name.Length - 1);
            }

            return name;
        }
    }
}
