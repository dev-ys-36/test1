using System;

namespace test1
{
    class Program
    {

        delegate void testFunction();

        public static void Main()
        {
            testFunction af = () =>
            {
                Console.WriteLine("anonymous function");
            };

            Func<int> func1 = () => 123;

            Console.WriteLine(func1());

            af();
            
            OldMethod();
        }

        //[Obsolete("legacy method")]
        public static void OldMethod()
        {
            Console.WriteLine("test");
        }

    }
}