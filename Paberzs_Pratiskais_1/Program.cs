using Paberzs_Pratiskais_1.Models;
using System;
using System.Linq;

namespace Praktiskais_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                context.Database.EnsureCreated();

                Console.WriteLine("=== Pievienot jaunu spēļu izstrādātāju (Developer) ===");

                Console.Write("Ievadiet kompānijas nosaukumu (piemēram, Valve): ");
                string devName = Console.ReadLine();

                Console.Write("Ievadiet valsti (piemēram, USA): ");
                string devCountry = Console.ReadLine();
                


                var newDeveloper = new Developer { Name = devName, Country = devCountry };
                context.Developers.Add(newDeveloper);
                context.SaveChanges();

                Console.WriteLine("\nDati veiksmīgi saglabāti datubāzē!\n");


                
                Console.WriteLine("=== Visi izstrādātāji datubāzē ===");
                var allDevelopers = context.Developers.ToList();

                if (allDevelopers.Any())
                {
                    foreach (var dev in allDevelopers)
                    {
                        Console.WriteLine($"ID: {dev.Id} | Nosaukums: {dev.Name} | Valsts: {dev.Country}");
                    }
                }
                else
                {
                    Console.WriteLine("Datubāzē nav neviena izstrādātāja.");
                }

                Console.WriteLine("\nNospiediet jebkuru taustiņu, lai izietu...");
                Console.ReadKey();
            }
        }
    }
}