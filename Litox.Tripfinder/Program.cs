using System;

namespace Litox.Tripfinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Airports.Add(new Airport { IATA = "GDN", Country = "Poland" });
            context.Airports.Add(new Airport { IATA = "WMI", Country = "Poland" });
            context.Airports.Add(new Airport { IATA = "WAW", Country = "Poland" });
            context.Airports.Add(new Airport { IATA = "BGY", Country = "Italy" });
            context.Airports.Add(new Airport { IATA = "KGD", Country = "Russia" });
            context.SaveChanges();

            foreach (var something in context.Airports)
            {
                Console.WriteLine(something.IATA);
                Console.WriteLine(something.ID);
                Console.WriteLine("__________________");
            }

            Console.ReadKey();
        }
    }
}