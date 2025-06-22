using System;

namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Singleton Logger...\n");

            // Get Logger instance and log messages
            Logger logger1 = Logger.GetInstance();
            logger1.Log("This is the first log message.");

            Logger logger2 = Logger.GetInstance();
            logger2.Log("This is the second log message.");

            // Verify that both instances are the same
            if (logger1 == logger2)
            {
                Console.WriteLine("\n✅ Both logger instances are the same (singleton verified).");
            }
            else
            {
                Console.WriteLine("\n❌ Logger instances are different (singleton failed).");
            }
        }
    }
}
