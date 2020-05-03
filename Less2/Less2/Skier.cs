using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib_for_less2;

namespace TaskSkier
{
    class Skier
    {

        public static void Main(string[] args)
        {
            var skierService = new SkierLib();

            Console.WriteLine("Enter x:");
            string x = Console.ReadLine();

            IsValidNumber(x);

            Console.WriteLine(" x: {0}", x);

            Console.WriteLine("Enter y:");
            string y = Console.ReadLine();

            IsValidNumber(y);

            Console.WriteLine(" y: {0}", y);

            Console.WriteLine("Enter z:");
            string z = Console.ReadLine();

            IsValidNumber(z);

            Console.WriteLine(" z: {0}", z);

            double km = double.Parse(x);
            int percent = int.Parse(y);
            int days = 1;
            double kmperdays = 0;
            double allkm = double.Parse(z);

            var result = skierService.Skier(kmperdays, km, allkm, percent, days);

            Console.WriteLine("Skier runs {0} km in {1} days", allkm, result);

            Console.ReadKey();
        }

        public static void IsValidNumber(string x)
        {
            while (!int.TryParse(x, out int xAsint))
            {
                Console.WriteLine("This is not a number!");
                x = Console.ReadLine();
            }
        }
    }
}
