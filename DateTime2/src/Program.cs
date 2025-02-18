using System;

namespace DateTime2 {
    class Program {
        static void Main(string[] args) {
            /* Propriedades do DateTime
            DateTime d = new DateTime(2025, 2, 18, 10, 32, 46, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);
            */

            /* Formatação de datas
            DateTime d = new DateTime(2025, 2, 18, 10, 32, 46);

            string s1 = d.ToLongDateString(); // Formatação de data longa
            string s2 = d.ToLongTimeString(); // Formatação de hora
            string s3 = d.ToShortDateString(); // Formatação de data curta
            string s4 = d.ToShortTimeString(); // Formatação de hora curta
            string s5 = d.ToString(); // Formatação padrão
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss"); // Formatação customizada
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff"); // Formatação customizada

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            */

            /* Operações com DateTime
            DateTime d = new DateTime(2025, 2, 18, 10, 32, 46);
            
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            DateTime dateTime = new DateTime(2000, 10, 15);
            DateTime dateTime2 = new DateTime(2000, 10, 18);
            TimeSpan t = dateTime2.Subtract(dateTime);
            Console.WriteLine();
            Console.WriteLine(t);
            */
        }
    }
}