using System;

namespace SingletonPatternExample
{
    public class Logger
    {
        // Step 1: Private static instance
        private static Logger _instance;

        // Step 2: Lock object for thread safety (optional but recommended in multithreaded apps)
        private static readonly object _lock = new object();

        // Step 3: Private constructor
        private Logger()
        {
            Console.WriteLine("Logger Initialized.");
        }

        // Step 4: Public static method to get the instance
        public static Logger GetInstance()
        {
            // Double-check locking pattern (for thread safety)
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                    }
                }
            }
            return _instance;
        }

        // A method to simulate logging
        public void Log(string message)
        {
            Console.WriteLine($"Log Entry: {message}");
        }
    }
}