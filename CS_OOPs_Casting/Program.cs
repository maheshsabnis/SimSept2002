using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CS_OOPs_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle rectangle = new Rectangle(100, 200);

            int ReactnglaArea = rectangle.CalculateArea();
            Console.WriteLine($"Area of Reactngle = {ReactnglaArea}");
            Console.WriteLine($"Half the Rea = {rectangle.GetHalfArea(ReactnglaArea)}");

            Square square = new Square(80);
            Console.WriteLine($"Area of Square = {square.CalculateArea()}");

            // Casting

            // Lets go for Upcasting
            // This will  only access methods of base class, because the  reference if os Base class
            // Althugh the BAse class is abstract, we can have memory alloctaed to it using
            // // instance of derived class and use this reference to access the  class method
            Shape shape = rectangle;

            Console.WriteLine($"Upcasting Area of Shape = {shape.CalculateArea()}");

            // Let's go for Downcasting

            Shape newShape = new Square(200);
            // Reference of the Derive class that is pointing to the Referencfe of base class
            // which is casted to the Derive class
            Square s1 = (Square)newShape;
            int area = s1.CalculateArea();
            Console.WriteLine($"Downcasting Area = {area}");

            Console.WriteLine($"Can Downcasting access method of the derive class {s1.GetSideDimension(area)}");
            

            Console.ReadLine();
        }
    }

    public abstract class Shape
    {
      protected int Height,Width;

        public Shape(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public abstract int CalculateArea();
    }

    public class Rectangle : Shape
    {
        // calling the base class constructor
        public Rectangle(int h,int w):base(h,w)
        {

        }
        public override int CalculateArea()
        {
            // calling the protected members of the base class
            return base.Height * base.Width;
        }

        public int GetHalfArea(int totalArea)
        {
            return totalArea / 2;
        }
    }

    public class Square : Shape 
    {
        public Square(int side): base(side,side)
        {
        }
        public override int CalculateArea()
        {
            return base.Height * base.Width;
        }

        public int GetSideDimension(int area)
        {
            return area / 4;
        }
    }
}
