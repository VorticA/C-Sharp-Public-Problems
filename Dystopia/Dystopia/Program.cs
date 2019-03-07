using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Dystopia
{
    class Program
    {
        private static List<IBuyer> buyers = new List<IBuyer>();
        private static int totalfood = 0;
        static void Main(string[] args)
        {

            //                       First Problem

            //List<Inhabitant> inhabs = new List<Inhabitant>();
            //while(true)
            //{
            //    var line = Console.ReadLine().Split().ToList();
            //    if (line[0].ToLower() == "end") break;
            //    else if (line.Count == 3)
            //        inhabs.Add(new Citizen(line[0], int.Parse(line[1]), line[2]));
            //    else
            //        inhabs.Add(new Robot(line[0], line[1]));
            //}
            //var fakes = Console.ReadLine();
            //inhabs.ForEach(p => { if (p.Id.EndsWith(fakes)) Console.WriteLine(p.Id); });


            //                    Second Problem

            //List<IBirthDateable> animals = new List<IBirthDateable>();
            //while (true)
            //{
            //    var line = Console.ReadLine().Split().ToList();
            //    if (line[0].ToLower() == "end") break;
            //    else if (line[0].ToLower() == "pet") animals.Add(new Pet(line[1], DateTime.Parse(line[2], CultureInfo.CreateSpecificCulture("fr-FR"))));
            //    else if (line[0].ToLower() == "citizen") animals.Add(new Citizen(line[1], int.Parse(line[2]), line[3], DateTime.Parse(line[4], CultureInfo.CreateSpecificCulture("fr-FR"))));
            //}
            //int yr = int.Parse(Console.ReadLine());
            //foreach (IBirthDateable item in animals)
            //{
            //    if (item.BirthDate.Year == yr) Console.WriteLine(item.BirthDate.ToShortDateString());
            //}


            //               Third Problem

            
            int n = int.Parse(Console.ReadLine());
            for (int i=0; i<n; i++)
            {
                var line = Console.ReadLine().Split().ToList();
                if (line.Count == 3) buyers.Add(new Rebel(line[0], int.Parse(line[1]), line[2]));
                else if (line.Count == 4) buyers.Add(new Citizen(line[0], int.Parse(line[1]), line[2], DateTime.Parse(line[3], CultureInfo.CreateSpecificCulture("fr-FR"))));
            }
            while (true)
            {
                var line = Console.ReadLine();
                if (line.ToLower() == "end") break;
                else
                {
                    BuyFor(line);
                }
            }
            Console.WriteLine(totalfood);
        }

        private static void BuyFor(string name)
        {
            foreach (IBuyer buyer in buyers)
            {
                if (buyer.Name == name) totalfood+=buyer.BuyFood();
            }
        }
    }
}
