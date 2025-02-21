using System;
using System.Globalization;

namespace DateTime1 {
    class Program {
        static void Main(string[] args) {

            /*DateTime d1 = new DateTime(2025, 02, 18);
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2025, 02, 18, 10, 01, 34);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2025, 02, 18, 10, 01, 34, 500);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);*/

            DateTime d1 = DateTime.Parse("2025-02-18");
            DateTime d2 = DateTime.Parse("2025-02-18 10:08:34");
            DateTime d3 = DateTime.Parse("18/02/2025");
            DateTime d4 = DateTime.Parse("18/02/2025 10:08:34");
            DateTime d5 = DateTime.ParseExact("2025-02-18", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d6 = DateTime.ParseExact("18/02/2025 10:08:34", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
        }
    }
}