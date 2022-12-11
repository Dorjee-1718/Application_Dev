using System;
namespace ApplicationDev.week_04
{
    public abstract class ShapeAbstract
    {
        public abstract int Area();
        public abstract int Perimeter();
    }


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

        public override int Area()
        {
            throw new NotImplementedException();
        }

        public override int Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}

