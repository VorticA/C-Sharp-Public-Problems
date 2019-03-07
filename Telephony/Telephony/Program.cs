using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            MobilePhone smartphone = new MobilePhone("Smartphone");
            List<string> Numbers = Console.ReadLine().Split().ToList();
            List<string> Websites = Console.ReadLine().Split().ToList();

            foreach (string number in Numbers)
            {
                try
                {
                    smartphone.Call(number);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (string website in Websites)
            {
                try
                {
                    smartphone.Browse(website);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
