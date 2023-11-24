namespace Array
{
    internal class Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eter 5 elements of array: ");
            double[] ar = new double[5];
            Array.Input(ar); // ввод элементов массива из 5 элементов
            Console.WriteLine("Sum of all elements =  {0}", Array.elementSum(ar)); // вывод суммы всех эелементов массива
            Console.WriteLine("Avarge value = {0}", Array.avargeVal(ar)); // вывод среднего значения эллементов массива
            Console.WriteLine("Sum of positiv elements = {0}\nSum of negativ elements = {1}",
                Array.plusMinisElementSum(ar).Item2, Array.plusMinisElementSum(ar).Item1); //вывод суммы положительный и суммый отрицательных элементов массива
            Console.WriteLine("Sum of elements with even indexes = {0}\nSum of elements with NON-even indexes = {1}",
                Array.evenNotevenElementSum(ar).Item2, Array.evenNotevenElementSum(ar).Item1); //вывод суммы элементов массива с чётными и не чётными индексами
            Console.WriteLine("Max element is {0} with index {1}\nMin element is {2} with index {3}",
                Array.minMaxElement(ar).Item1, Array.minMaxElement(ar).Item2, Array.minMaxElement(ar).Item3, Array.minMaxElement(ar).Item4); // Вывод максимального и минимального эллемента с индексами
            Console.WriteLine("Multiplication of all elements between max and min = {0}", Array.multElement(ar)); //Вывод произведения элементов между максимальным и минимальным
        }
        public static void Input(double[] someArray)
        {
            for (int i = 0; i < someArray.Length; i++)
            {
                someArray[i] = double.Parse(Console.ReadLine());
            }
        }
        public static double elementSum(double[] someArray)
        {
            double sum = 0;
            foreach (double i in someArray)
            {
                sum += i;
            }
            return sum;
        }
        public static double avargeVal(double[] someArray)
        {
            double avVal = Array.elementSum(someArray)/someArray.Length;
            return avVal;
        }
        public static (double, double) plusMinisElementSum(double[] someArray)
        {
            double plusSum = 0;
            double minusSum = 0;
            foreach (double i in someArray)
            {
                if (i < 0) {minusSum += i;}
                else {plusSum += i;}
            }
            return (minusSum, plusSum);
        }
        public static (double, double) evenNotevenElementSum(double[] someArray)
        {
            double evenSum = 0;
            double notevensSum = 0;
            for (int i = 0; i<someArray.Length; i++)
            { 
                if (i % 2 == 0) { evenSum += someArray[i]; }
                else { notevensSum += someArray[i];}
            }
            return (notevensSum, evenSum);
        }
        public static (double, int, double, int) minMaxElement(double[] someArray)
        {
            double max = 0;
            double min = 0;
            int maxIndex = 0;
            int minIndex = 0;
            int temp = 0;
            foreach (int i in someArray)
            {
               if (max <= i)
               {
                    max = i;
                    maxIndex = temp;
               }
               if (min >= i)
               {
                    min = i;
                    minIndex = temp;
               }
               temp++;
            }    
            return (max, maxIndex, min, minIndex);
        }
        public static double multElement(double[] someArray)
        {
            if (minMaxElement(someArray).Item4 == minMaxElement(someArray).Item2 ||
                (minMaxElement(someArray).Item4 - minMaxElement(someArray).Item2) == 1 ||
                (minMaxElement(someArray).Item4 - minMaxElement(someArray).Item2) == -1)
            { return 0; }
            else
            {
                double multip = 1;
                if (minMaxElement(someArray).Item2 > minMaxElement(someArray).Item4)
                {
                    for (int i = (minMaxElement(someArray).Item4 + 1); i < minMaxElement(someArray).Item2; i++)
                    {
                        multip *= someArray[i];
                    }
                }
                else
                {
                    for (int i = (minMaxElement(someArray).Item2 + 1); i < minMaxElement(someArray).Item4; i++)
                    {
                        multip *= someArray[i];
                    }
                }
                return multip;
            }
        }
    }
}