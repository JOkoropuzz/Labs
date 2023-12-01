
namespace Shapes
{
    class Square : Shape, IRotation
    {
        private double Side;

        public Square(double a, string col) : base(col)
        {
            Side = a;
            base.Name = "Квадрат";
            base.AngelAmount = 4;
            base.Square = this.AreaSquare();
        }

        public Square(double a)
        {
            Side = a;
            base.Name = "Квадрат";
            base.AngelAmount = 4;
            base.Square = this.AreaSquare();
        }


        public override void Show()
        {
            if (this.ShapeExist())
            {
                base.Show();
                Console.WriteLine($"Сторона: {this.Side}\nПериметр: {this.Perimeter():F3}");
            }
            else { Console.WriteLine("Квадрата не существует!"); }
        }

        public override bool ShapeExist() => (this.Side > 0);

        public double Perimeter() => (this.Side*4);

        public double AreaSquare() => this.Side * this.Side;

        public void Rotation(int degree, string clockwise)
        {
            Console.WriteLine($"Для фигуры {this.Name} выполнен поворот {clockwise} на {degree} градусов.");
        }
    }
}
