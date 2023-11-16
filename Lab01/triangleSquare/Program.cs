
using System.Reflection.Metadata;

double pirimeter;
double triangleSide;
double square;
Console.WriteLine("Enter the perimeter of the equilateral triangle");
pirimeter = double.Parse(Console.ReadLine());
triangleSide = pirimeter / 3;
square = Math.Sqrt((pirimeter / 2) * Math.Pow(((pirimeter / 2) - triangleSide), 3));
Console.WriteLine("Side | Square");
Console.WriteLine(Math.Round(triangleSide, 2) + " | " + Math.Round(square, 2));