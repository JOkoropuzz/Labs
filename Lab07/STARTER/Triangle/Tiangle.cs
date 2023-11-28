using System;
class Triangle : IComparable
{
    private double aSide;
    private double bSide;
    private double cSide;
    private double square;


    public int CompareTo(object obj) 
    {
        Triangle it = (Triangle)obj;
        if (this.square == it.square) return 0;
        else if (this.square > it.square) return 1;
        else return -1;
    }
    public Triangle(double a, double b, double c)  //Конструткор треугольника с разными сторонами
    {
        aSide = a; bSide = b; cSide = c;
    }

    public Triangle(double a) //Конструктор равностороннего треугольника
    {
        aSide = a; bSide = a; cSide = a;
    }

    public double Pirimeter() //Возвращает периметр треугольника
    {
        return (aSide + bSide + cSide);
    }
    public double Square()  //Возвращает площадь треугольника по формуле Герона
    {
        square = Math.Sqrt((Pirimeter() / 2) * ((Pirimeter() / 2) - aSide) * ((Pirimeter() / 2) - bSide) * ((Pirimeter() / 2) - cSide));
        return square;
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
class Program
{
    public static void Main() 
    {
        Triangle t1 = new Triangle(5);
        Triangle t2 = new Triangle(9);
        Triangle t3 = new Triangle(5,8,3);
        Triangle[] triangles = { t1, t2, t3 };
        Console.WriteLine("Befor Sorting:");
        foreach (Triangle i in triangles) Console.WriteLine(i.Square());
        Console.WriteLine("After Sorting:");
        Array.Sort(triangles);
        foreach (Triangle i in triangles) Console.WriteLine(i.Square());
    }
}