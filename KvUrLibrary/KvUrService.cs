using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvUrLibrary
{
    public class KvUrService
    {
        public double Discriminant(int a, int b, int c)
        {
            if(a == int.MaxValue || b == int.MaxValue || c == int.MaxValue)
            {
                return 0;
            }

            double discriminant = (b * b) - (4 * a * c);

            return discriminant;
        }

        public void Roots(int a, int b, double discriminant)
        {
            if (discriminant < 0)
            {
                Console.WriteLine("No roots");
            }

            else if (discriminant == 0)
            {
                double x = (-b + Math.Sqrt(discriminant)) / 2 * a;

                Console.WriteLine("Discriminant = {0}, than root = {1}", discriminant, x);
            }

            else if (discriminant > 0)
            {
                double x = (-b + Math.Sqrt(discriminant)) / 2 * a;

                double x1 = (-b - Math.Sqrt(discriminant)) / 2 * a;

                Console.WriteLine("Discriminant = {0}, than roots = {1} and {2}", discriminant, x, x1);
            }
        }
    }
}
