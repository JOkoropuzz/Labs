
namespace Shapes
{
    internal class Shape : IComparable
    {
        protected string Name = "Без названия";
        protected int AngelAmount;
        protected double Square = 0;
        protected string Colour = "Без цвета";

        public Shape() 
        { }

        public Shape(string name, string col, int ang, double square)
        {
            Name = name;
            AngelAmount = ang;
            Square = square;
            Colour = col;
        }

        public Shape(string col)
        {
            Colour = col;
        }

        public int CompareTo(object obj)  //Сравнение фигур по площади
        {
            Shape it = (Shape)obj;
            if (this.Square == it.Square) return 0;
            else if (this.Square > it.Square) return 1;
            else return -1;
        }

        public virtual void Show() //Вывод в консоль параметров фигуры
        {
            Console.WriteLine($"Фигура: {this.Name}\nЦвет: {this.Colour}\nКол-во углов: {this.AngelAmount}\nПлощадь: {this.Square:F3}");
        }

        public virtual bool ShapeExist() => (this.Square > 0); //Проверка существования фигуры
        
        public void ColourChange(string col) => this.Colour = col;

        public void NameChange(string name) => this.Name = name;

        public double ReturnSquare() => this.Square;
    }
}
