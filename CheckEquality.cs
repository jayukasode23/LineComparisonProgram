using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class CheckEquality
    {
        public static void CheckEqual()
        {
            //Compare Two Lines L1 and L2
            //Line1:
            Console.WriteLine("Enter values of Line No 1: ");

            Console.WriteLine("Enter values of: X1 ");
            int X1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values of: X2 ");
            int X2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values of: Y1 ");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values of: Y2 ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            //Line2:
            Console.WriteLine("Enter values of Line No 2: ");

            Console.WriteLine("Enter values of: X3 ");
            int X3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values of: X4 ");
            int X4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values of: Y3 ");
            int Y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values of: Y4 ");
            int Y4 = Convert.ToInt32(Console.ReadLine());

            //using double to get sqaure root and double decimal value

            double L1 = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));
            Console.WriteLine("Length of Line is: + L1");

            double L2 = Math.Sqrt((Math.Pow((X4 - X3), 2) + Math.Pow((Y4 - Y3), 2)));
            Console.WriteLine("Length of Line is: + L2");
            if (L1 == L2)
            {
                Console.WriteLine("Both Lines are Equal");
            }
            else
            {
                Console.WriteLine("Both Lines are Not Equal");
            }

        }
    }
}
    