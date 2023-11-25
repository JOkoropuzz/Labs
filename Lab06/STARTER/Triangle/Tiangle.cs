
class Triangle
{
    private double aSide;
    private double bSide;
    private double cSide;

    public void Populate(double a, double b, double c)
    {
        aSide = a; bSide = b; cSide = c;
    }

    public double Pirimeter() //Возвращает периметр треугольника
    {
        return (aSide + bSide + cSide);
    }
    public double Square()  //Возвращает площадь треугольника по формуле Герона
    {
        return Math.Sqrt((Pirimeter() / 2) * ((Pirimeter() / 2) - aSide) * ((Pirimeter() / 2) - bSide) * ((Pirimeter() / 2) - cSide));
    }
    public void ToWrite() //Вывод в консоль трёх сторон треугольника
    {
        Console.WriteLine("A side = {0}\nB side = {1}\nC side = {2}", aSide, bSide, cSide);
    }

    public bool TriangleExist() //Проверка существования треугольника (True - сущесвтует, False - не сущесвтует)
    {
        bool existenc = true;
        if ((aSide + bSide) <= cSide) { existenc = false; }
        if ((bSide + cSide) <= aSide) { existenc = false; }
        if ((aSide + cSide) <= bSide) { existenc = false; }
        return existenc;
    }
}
class Program//Проверка выполнения методов класса Triangle
{
    static void Main() 
    {
        Triangle testTriangle = new Triangle();
        Console.WriteLine("Enter first side of triangle: ");
        double a = double.Parse((Console.ReadLine()));
        Console.WriteLine("Enter second side of triangle: ");
        double b = double.Parse((Console.ReadLine()));
        Console.WriteLine("Enter second side of triangle: ");
        double c = double.Parse((Console.ReadLine()));
        testTriangle.Populate(a, b, c); 
        if (testTriangle.TriangleExist()) 
        {
            testTriangle.ToWrite();
            Console.WriteLine("This triangle exist");
            Console.WriteLine("Pirimeter of triangle = {0}", testTriangle.Pirimeter());
            Console.WriteLine("Square of triangle = {0}", testTriangle.Square());
        }
        else { Console.WriteLine("This triangle NOT exist"); }
        
    }
}