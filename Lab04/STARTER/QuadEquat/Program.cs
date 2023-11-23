using System.ComponentModel;

namespace QuadEquat
{
    public class Operation
    {
        public static (double, double, int) Root(double a, double b, double c)
        {
            double D = (b*b) - (4*a*c);
            switch (D)
            {
                case 0:
                    return ((-b) / (2 * a), (-b) / (2 * a), 0);

                case < 0:;
                    return (0, 0, -1);

                case > 0:
                    return ((Math.Sqrt(D) - b) / (2 * a), (-Math.Sqrt(D) - b) / (2 * a), 1);
                default: 
                    return (0, 0, 2);
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
            switch (Operation.Root(a, b, c).Item3)
            {
                case -1:
                    Console.WriteLine($"Root of the quadratic equation with coefficients a = {a} b = {b} c = {c} NOT exist.");
                    break;
                case 0:
                    Console.WriteLine($"The quadratic equation with coefficients a = {a} b = {b} c = {c} have only one root x1 = x2 = {Operation.Root(a, b, c).Item1}.");
                    break;
                case 1:
                    Console.WriteLine($"The quadratic equation with coefficients a = {a} b = {b} c = {c} have two roots x1 = {Operation.Root(a, b, c).Item1} x2 = {Operation.Root(a, b, c).Item2}.");
                    break;
                case 2:
                default: Console.WriteLine("Something went wrong"); break;

            }
        }
    }
}