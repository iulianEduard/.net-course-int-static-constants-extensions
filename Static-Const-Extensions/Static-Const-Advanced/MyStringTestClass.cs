namespace Static_Const_Advanced
{
    public static class MyStringTestClass
    {
        public const string ConstString = "Const String";
        public static readonly string StaticReadonly;

        static MyStringTestClass()
        {
            StaticReadonly = "Static ReadOnly String";
        }
    }
}
