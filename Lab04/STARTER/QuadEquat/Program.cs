using System.ComponentModel;

namespace QuadEquat
{
    public class Operation
    {
        public static int Root(double a, double b, double c, out double x1, out double x2)
        {
            int n;
            double D = (b*b) - (4*a*c);
            switch (D)
            {
                case 0:
                    x1 = (-b)/(2*a);
                    x2 = x1;
                    n = 0;
                    return n;

                case < 0:
                    x1 = 0;
                    x2 = 0;
                    n = -1;
                    return n;

                case > 0:
                    x1 = (Math.Sqrt(D) - b)/ (2 * a);
                    x2 = (- Math.Sqrt(D) - b) / (2 * a);
                    n = 1;
                    return n;
                default:
                    x1= 0;
                    x2= 0;
                    n = 2;
                    return n;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first coefficient (a) of quadratic equation: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second coefficient (b) of quadratic equation: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third coefficient (c) of quadratic equation: ");
            double c = double.Parse(Console.ReadLine());
            double root1, root2;
            switch (Operation.Root(a, b, c, out root1, out root2))
            {
                case -1:
                    Console.WriteLine($"Root of the quadratic equation with coefficients a = {a} b = {b} c = {c} NOT exist.");
                    break;
                case 0:
                    Console.WriteLine($"The quadratic equation with coefficients a = {a} b = {b} c = {c} have only one root x1 = x2 = {root1}.");
                    break;
                case 1:
                    Console.WriteLine($"The quadratic equation with coefficients a = {a} b = {b} c = {c} have two roots x1 = {root1} x2 = {root2}.");
                    break;
                case 2:
                default: Console.WriteLine("Something went wrong"); break;

            }
        }
    }
}