
namespace Shapes
{
    class Triangle : Shape, IRotation
    {
        private double aSide;
        private double bSide;
        private double cSide;

        
        public Triangle(double a, double b, double c, string col) : base(col)
        {
            aSide = a; bSide = b; cSide = c;
            base.Name = "Треугольник";
            base.Square = this.TriangleSquare();
            base.AngelAmount = 3;
        }
        public Triangle(double a, double b, double c)  //Конструткор треугольника с разными сторонами
        {
            aSide = a; bSide = b; cSide = c;
            base.Name = "Треугольник";
            base.Square = this.TriangleSquare();
            base.AngelAmount = 3;
        }


        public Triangle(double a) //Конструктор равностороннего треугольника
        {
            aSide = a; bSide = a; cSide = a;
            base.Name = "Треугольник";
            base.Square = this.TriangleSquare();
            base.AngelAmount = 3;
        }


        public void Rotation(int degree, string clockwise)
        {
            Console.WriteLine($"Для фигуры {this.Name} выполнен поворот {clockwise} на {degree} градусов.");
        }

        public double Pirimeter() //Возвращает периметр треугольника
        {
            return (aSide + bSide + cSide);
        }


        public double TriangleSquare()  //Возвращает площадь треугольника по формуле Герона
        {
            double square = Math.Sqrt((Pirimeter() / 2) * ((Pirimeter() / 2) - aSide) * ((Pirimeter() / 2) - bSide) * ((Pirimeter() / 2) - cSide));
            return square;
        }


        public override void Show() //Вывод в консоль параметров, если треугольник существует
        {
            if (this.ShapeExist()) 
            {
                base.Show();
                Console.WriteLine("Сторона А = {0}\nСторона В = {1}\nСторона С= {2}", aSide, bSide, cSide);
            }
            else Console.WriteLine("Треугольника не существует!");
            
        }


        public override bool ShapeExist() //Проверка существования треугольника (True - сущесвтует, False - не сущесвтует)
        {
            bool existenc = true;
            if ((aSide + bSide) <= cSide) { existenc = false; }
            if ((bSide + cSide) <= aSide) { existenc = false; }
            if ((aSide + cSide) <= bSide) { existenc = false; }
            return existenc;
        }

    }
}