using System;

namespace FinancialForecasting
{
    public class ForecastCalculator
    {
        // Recursive version: O(n)
        public static double CalculateFutureValueRecursive(double initialValue, double growthRate, int years)
        {
            if (years == 0)
                return initialValue;

            return CalculateFutureValueRecursive(initialValue, growthRate, years - 1) * (1 + growthRate);
        }

        // Iterative version: O(n), avoids recursion depth issues
        public static double CalculateFutureValueIterative(double initialValue, double growthRate, int years)
        {
            double result = initialValue;
            for (int i = 0; i < years; i++)
            {
                result *= (1 + growthRate);
            }
            return result;
        }
    }
}
