using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T17_2_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bus> bus = new List<Bus>();
            bus.Add(new Bus("MEN", 20, 150));
            bus.Add(new Touristbus("MEN", 20, 150,70));

            foreach (var buss in bus)
            {
                buss.Info();
            }
            ReadKey();
        }
    }
}
