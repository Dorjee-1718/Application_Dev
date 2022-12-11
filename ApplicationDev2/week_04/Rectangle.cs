using System;
using ApplicationDev.week_04;
namespace VariableDrive.cs.week_04
{
    public class Rectangle : ShapeAbstract
    {
        /*
        public static void UserInput()
        {
            Console.WriteLine("Enter length for the rectangle: ");
            length = Convert.ToInt32(Console.ReadLine());
        }
        */

        public static void Area(int length, int breadth)
        {
            int area = length * breadth;
            Console.WriteLine($"Area of rectangle : {area}");
        }

        public static void Perimeter(int length, int breadth)
        {
            int perimeter = 2 * (length + breadth);
            Console.WriteLine($"Perimeter of rectangle : {perimeter}");
        }
    }
}

