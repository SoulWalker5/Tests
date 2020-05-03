using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KvUrLibrary;

namespace Kvadratnoe_Uravnenie
{
    public class KvadratnoeUravnenie
    {
        static void Main(string[] args)
        {
            var kvUrService = new KvUrService();

            int a, b, c;
            Console.Write("a= ");
            a = ReadNumberFromConsole();
            Console.Write("b= ");
            b = ReadNumberFromConsole();
            Console.Write("c= ");
            c = ReadNumberFromConsole();

            var d = kvUrService.Discriminant(a, b, c);

            kvUrService.Roots(a, b, d);

            Console.ReadKey();
        }
        static int ReadNumberFromConsole()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Incorrect number, try again");
            }

            return number;
        }
    }
}
