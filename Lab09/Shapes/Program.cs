namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle test = new Triangle(3, 4, 5, "зелёный");
            Circle teseCir1 = new Circle(3);
            Circle teseCirCol = new Circle(4, "Красный");
            Circle teseCir2 = new Circle(0);
            Circle teseCir3 = new Circle(-2);
            Triangle test2 = new Triangle(3);
            Triangle test3 = new Triangle(5);
            Triangle test4 = new Triangle(8);
            Triangle test5 = new Triangle(9);
            Square squer1 = new Square(-2, "Насыщенный пурпурно-синий");
            Square squer2 = new Square(3);

            squer2.Rotation(38, "По часовой");

            Shape[] shapes = { test, test2, test3, test4, test5, teseCir1, teseCir2, teseCir3, teseCirCol, squer2, squer1};


            Console.WriteLine("До сортировки");
            foreach (Shape i in shapes) 
            {
                if(i.ShapeExist())Console.WriteLine(i.ReturnSquare()); 
            }


            Array.Sort(shapes);


            Console.WriteLine("После сортировки");
            foreach (Shape i in shapes)
            {
                if (i.ShapeExist()) Console.WriteLine(i.ReturnSquare());
            }
        }
    }
}
