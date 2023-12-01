
namespace Shapes
{
    class Circle : Shape
    {
        private double Radius;


        public Circle (double r)
        {
            Radius = r;
            base.Name = "Окружность";
            base.AngelAmount = 0;
            base.Square = this.CircleSquare();
            
        }

        public Circle(double r, string col) : base(col)
        {
            Radius = r;
            base.Name = "Окружность";
            base.AngelAmount = 0;
            base.Square = this.CircleSquare();

        }

        public override void Show()
        {
            if (this.ShapeExist())
            {
                base.Show();
                Console.WriteLine($"Радиус: {this.Radius}\nПериметр: {this.Perimeter():F3}");
            }
            else { Console.WriteLine("Окружности не существует!"); }
        }

        public override bool ShapeExist() //Проверка существования круга
        {
            if (this.Radius > 0) return true;
            else return false;
        }

        public double CircleSquare() => Math.PI * Math.Pow(this.Radius, 2); //Возврат площади круга

        public double Perimeter() => (2 * Math.PI * this.Radius); //Возврат периметра круга

    }
}
