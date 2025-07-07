using System;
using Lab2_DbContext.Data;

namespace Lab2_DbContext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🔗 Connecting to SQL Server using EF Core...");

            using var context = new AppDbContext();

            if (context.Database.CanConnect())
            {
                Console.WriteLine("✅ Connection successful! DbContext is configured properly.");
            }
            else
            {
                Console.WriteLine("❌ Failed to connect to the database. Check your connection string.");
            }
        }
    }
}
