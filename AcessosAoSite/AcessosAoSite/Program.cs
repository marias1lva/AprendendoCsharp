using System;
using System.IO;
using AcessosAoSite.Entities;

namespace AcessosAoSite {
    class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter a file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(' ');
                        string username = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = username, Instant = instant });        
                    }
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}