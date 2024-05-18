
using System;

namespace ShapeAreaCalculator
{
    
    class ShapeAreaCalculator
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What shape would you like to find the area of?");
            Console.WriteLine("Please enter r for rectangle, c for circle, s for square, t for triangle and o for other shapes");
            string response = Console.ReadLine().ToLower();

            switch (response)
            {
                case "r":
                Console.WriteLine("Please enter the width of the rectangle");
                float width = Convert.ToSingle(Console.ReadLine());    
                Console.WriteLine("Please enter the height of the rectangle");
                float height = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("The area of the rectangle is: "+ width*height);
                break;
                case "s":
                    Console.WriteLine("Please enter the length of the square");
                    float length = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("The area of the square is: " + length * length);
                    break;
                case "c":
                    Console.WriteLine("Please enter the radius of the circle");
                    float radius= Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("The area of the circle is "+ Math.PI*radius*radius);
                    break;
                case "t":
                    Console.WriteLine("Please enter the base of the triangle");
                    float baselength = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("Please enter the height of the triangle");
                    float triangleheight = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine("The area of the triangle is: " + 0.5* baselength * triangleheight);
                    break;
                case "o":
                    Console.WriteLine("We are still improving, we would add it to our calculator soon");
                    break;

            }
           
        }
    }
}