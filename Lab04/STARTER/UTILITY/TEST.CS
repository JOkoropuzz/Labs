namespace Utils
{
    using System;

   

    public class Test
    {
        public static void Main()
        {
            Console.WriteLine("Enter x and y: ");
            string[] numbers = Console.ReadLine().Split(' ');
            int x = int.Parse(numbers[0]);
            int y = int.Parse(numbers[1]);
            int greater;
            greater = Utils.Greeter(x, y);
            Console.WriteLine(greater);
            Console.WriteLine($"{x} {y}");
            Utils.Swap(ref x, ref y);
            Console.WriteLine($"{x} {y}");
            bool ok = default;
            int f;
            ok = Utils.Factorial(x, out f);
            if (ok) { Console.WriteLine($"Factorial {x} = {f}"); }
            else  Console.WriteLine($"Cannot comput this factorial"); 

        }
    }
}
