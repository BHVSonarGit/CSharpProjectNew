using System;
namespace SomeConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var iAmTrue = true;
            if (iAmTrue)
            {
                Console.WriteLine("true");
                Console.WriteLine("1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890");
            }
            else
            {
                Console.WriteLine("false");
                Console.WriteLine("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz");
            }

            Console.ReadKey();
        }

        public static bool alwaysReturnsTrue()
        {
            return true;
        }

        public static object Passthrough(object obj)
        {
            return obj;
        }
    }
}
