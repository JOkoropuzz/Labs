
using System.Reflection.Metadata;

Console.WriteLine("Enter the perimeter of the equilateral triangle");
double pirimeter = double.Parse(Console.ReadLine());
double triangleSide = pirimeter / 3;
double square = Math.Sqrt((pirimeter / 2) * Math.Pow(((pirimeter / 2) - triangleSide), 3));
Console.WriteLine("Side | Square");
Console.WriteLine(Math.Round(triangleSide, 2) + " | " + Math.Round(square, 2));