using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("📈 Financial Forecasting Tool\n");

            // Sample input values
            double initialInvestment = 10000.00;
            double annualGrowthRate = 0.05; // 5%
            int forecastYears = 10;

            Console.WriteLine($"Initial Investment: ₹{initialInvestment}");
            Console.WriteLine($"Annual Growth Rate: {annualGrowthRate * 100}%");
            Console.WriteLine($"Forecast Duration: {forecastYears} years\n");

            // Recursive calculation
            double futureValueRecursive = ForecastCalculator.CalculateFutureValueRecursive(initialInvestment, annualGrowthRate, forecastYears);
            Console.WriteLine($"📊 Recursive Forecast Value: ₹{futureValueRecursive:F2}");

            // Iterative calculation
            double futureValueIterative = ForecastCalculator.CalculateFutureValueIterative(initialInvestment, annualGrowthRate, forecastYears);
            Console.WriteLine($"📊 Iterative Forecast Value: ₹{futureValueIterative:F2}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}