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
            if (a == int.MaxValue || b == int.MaxValue || c == int.MaxValue)
            {
                return 0;
            }

            double discriminant = (b * b) - (4 * a * c);

            return discriminant;
        }

        public (double, double) Roots(int a, int b, double discriminant)
        {
            (double, double) result;
            //double[] result = new double[2];

            if (a == int.MaxValue || b == int.MaxValue || discriminant == double.MaxValue)
            {
                result.Item1 = 0;
                result.Item2 = 0;

                return result;                
                
                //return new double[] { 0d };
            }

            if (a == int.MinValue || b == int.MinValue || discriminant == double.MinValue)
            {
                result.Item1 = 0;
                result.Item2 = 0;

                return result;

                //return new double[] { 0d };
            }

            if (discriminant < 0)
            {
                Console.WriteLine("No roots");

                result.Item1 = 0;
                result.Item2 = 0;

                return result;

                //return result;
            }

            else if (discriminant == 0)
            {
                double x = (-b + Math.Sqrt(discriminant)) / (2 * a);
                //result[0] = x;
                result.Item1 = x;
                result.Item2 = 0;

                Console.WriteLine("Discriminant = {0}, than root = {1}", discriminant, x);

                return result;
            }

            else
            {
                double x = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                result.Item1 = x;
                result.Item2 = x1;

                //result[0] = x;
                //result[1] = x1;

                Console.WriteLine("Discriminant = {0}, than roots = {1} and {2}", discriminant, x, x1);

                return result;
            }
        }
    }
}
