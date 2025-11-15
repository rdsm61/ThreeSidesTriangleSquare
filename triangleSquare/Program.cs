using System;

namespace ThreeSidesTriangleSquare
{
    class Operation
    {
        public static double SquareByHeron(double a, double b, double c)
        {
            double halfPerimeter = 0.5 * (a + b + c);
            if (IsTriangle(a, b, c))
            {
                return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            }
            else
            {
                Console.WriteLine("There is no triangle with sides {0}, {1}, {2}", a, b, c);
                return 0;
            }
                
        }

        private static bool IsTriangle(double a, double b, double c)
        {
            
            if (a < b + c && b < a + c && c < a + b)
                return true;
            else
                return false;
        }

        public static double SquareByHeron(double a)
        {
            double halfPerimeter = 3 * a / 2;

            return Math.Sqrt(halfPerimeter*(halfPerimeter-a) * (halfPerimeter - a) * (halfPerimeter - a));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is triangle regular? (y/n)");
            string answear = Console.ReadLine();
            if (answear == "y")
            {
                Console.WriteLine("Enter side of the triangle");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Square of the regular triangle with side {0} is {1:N3}", a, Operation.SquareByHeron(a));
            }
            else
            {
                Console.WriteLine("Enter three sides of the triangle");
                string temp = Console.ReadLine();
                double a = double.Parse(temp.Split()[0]);
                double b = double.Parse(temp.Split()[1]);
                double c = double.Parse(temp.Split()[2]);
                double square = Operation.SquareByHeron(a, b, c);
                if (square > 0)
                    Console.WriteLine("Square of the triangle with sides {0}, {1}, {2} is {3:N3}",
                        a, b, c, square);
            }
        }
    }
}
