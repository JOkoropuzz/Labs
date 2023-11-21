namespace AlgTask
{
    internal class Sqrrt
    {
        static double sqrtIt(double target)
        {
            double a = 1;
            double olda;
            do
            {
                
                olda = a;
                a = (a + target / a) / 2;
            }
            while (olda != a);
            return a;
        }
        static void Main(string[] args)
        {
            double target = 144;
            Console.WriteLine(sqrtIt(target));
            Console.WriteLine(sqrtIt(target) * sqrtIt(target));
        }
    }
}