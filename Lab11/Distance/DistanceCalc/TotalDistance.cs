namespace DistanceCalc
{
   
    internal class TotalDistance
    {
        static void Main(string[] args)
        {
            try
            {
                Distance firstDist = new Distance();
                Distance secondDist = new Distance();
                Console.WriteLine("Enter feet for the first distance:");
                firstDist.feet = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter inches for the first distance:");
                firstDist.inches = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter feet for the second distance:");
                secondDist.feet = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter inches for the second distance:");
                secondDist.inches = double.Parse(Console.ReadLine());
                Distance thirdDist = firstDist + secondDist;
                Distance fourDist = firstDist - secondDist;
                Console.WriteLine($"Сумма = {thirdDist.ToString()}\nРазность = {fourDist.ToString()}");
            }
            catch (Exception e) 
            {
                Console.WriteLine($"An exception was throw: {e.Message}");
            }
        }
    }
}