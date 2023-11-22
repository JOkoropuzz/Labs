using System.Reflection.Metadata.Ecma335;

namespace TriangSquare
{

    public class Operation
    {
        public static double TriangSquare(double a, double b, double c) // Расчёт площади треугольника по формуле Герона с проверкой на сущесвтование 
        {
            if (TriangExist(a, b, c)) 
            {
            double square = Math.Sqrt(((a + b + c) / 2) * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
            return square;
            }
            else return 0;
        }


        private static bool TriangExist(double a, double b, double c) // Метод проверки существования треугольника
        {
            bool ok = true;
            if ((a + b) < c) { ok = false; }
            if ((a + c) < b) { ok = false; }
            if ((b + c) < a) { ok = false; }
            return ok;
        }


        public static double TriangSquare(double a) // Расчёт площади равностороннего треугольника
        {
            double square = Math.Sqrt((a*3 / 2) * (Math.Pow(((a*3 / 2)-a), 3)));
            return square;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Is your triangle equilateral? y/n");
            string answer = Console.ReadLine();
            if (answer != "y" && answer != "n") { Console.WriteLine("Incorrect input!"); } // Проверка введения y/n
            else
            {
                if (answer == "y") // Равносторонний треугольник
                {
                    Console.WriteLine("Enter side of equilateral triangle: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Square of triangle = {0}", Operation.TriangSquare(a));
                }
                else // Треуголник не равносторонний. Внутри метода Operation.TriangSquare осуществляется провернка
                {
                    Console.WriteLine("Enter side a of triangle: ");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side a of triangle: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter side a of triangle: ");
                    double c = double.Parse(Console.ReadLine());
                    if (Operation.TriangSquare(a,b,c) == 0) { Console.WriteLine("Tiangle NOT exist!"); } // Если метод вернул 0, значит треугольника не существует
                    else Console.WriteLine("Square of triangle = {0}", Operation.TriangSquare(a, b, c));
                }
            }
            
        }
    }
}