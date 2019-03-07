using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ICar seat = new Seat("Leon", "Grey");
                ICar tesla = new Tesla("Model 3", "Red", 3);

                Console.WriteLine(seat.ToString());
                Console.WriteLine(tesla.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
