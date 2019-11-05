using Static_Const_Advanced;

namespace Static_Const_Extensions.Const_Read_Samples
{
    public class MyStringTestClassSample
    {
        public void SampleMethod()
        {
            string sro = MyStringTestClass.StaticReadonly;
            SomeOtherFunction(sro);
            string sc = MyStringTestClass.ConstString;
            SomeOtherFunction(sc);
        }

        public void SomeOtherFunction(string input)
        {
            // Dummy function to prevent "string sc"
            // being optimized away by the compiler
            System.Console.WriteLine(input);
        }
    }
}
