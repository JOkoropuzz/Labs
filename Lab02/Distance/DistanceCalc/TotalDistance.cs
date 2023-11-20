namespace DistanceCalc
{
    public struct Distance
    {
        public int feet;
        public int inches;
    }
    internal class TotalDistance
    {
        static void Main(string[] args)
        {
            try
            {
                Distance firstDist;
                Distance secondDist;
                Console.WriteLine("Enter feet for the first distance:");
                firstDist.feet = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter inches for the first distance:");
                firstDist.inches = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter feet for the second distance:");
                secondDist.feet = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter inches for the second distance:");
                secondDist.inches = int.Parse(Console.ReadLine());
                Distance totalDist;
                totalDist.inches = (firstDist.inches + secondDist.inches) % 12; // остаток дюймов после перевода в футы (кол-во дюймов суммарной дистанции)
                totalDist.feet = ((firstDist.inches + secondDist.inches) / 12) + firstDist.feet + secondDist.feet; // суммарное кол-во футов
                Console.WriteLine($"Total distance: {totalDist.feet}'-{totalDist.inches}\"");
            }
            catch (Exception e) 
            {
                Console.WriteLine($"An exception was throw: {e.Message}");
            }
        }
    }
}