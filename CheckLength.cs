using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class CheckLength
    {
        public static void LineComparison()
        {
            Console.WriteLine("Enter value of : X1");
            int X1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of : X2");
            int X2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of : Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter value of : Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine());


            double value = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Check the Length " + value);
        }
    }
}
