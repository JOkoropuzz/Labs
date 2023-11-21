namespace modu_2_
{
    class LoopProgram
    {
        static void Main()
        {
            Console.WriteLine("Please enter integer number: ");
            int number = int.Parse(Console.ReadLine());
            int sumNumber = 0;
            do
            {
                sumNumber += number % 10;
                number /= 10;
            }
            while (number != 0);
            Console.WriteLine($"S = {sumNumber}");
        }

    }
}