namespace NkrumHub
{
    class program
    {
        public interface IShape
        {
            public void getArea();

            public void getPerimeter();
        }

        public abstract class AbstractShape : IShape
        {
            public void getArea()
            {

            }
            public void getPerimeter() { }

            public string Color;
            public string getColor()
            { return Color; }

            public void setColor(string color)
            {
                Color = color;
            }
        }

        public class Rectangle : AbstractShape
        {
            public double width;
            public double height;

            public void setWidth(double Width)
            {
                width = Width;
            }

            public void setHeight(double Height)
            {
                height = Height;
            }

            public double getWidth()
            {

            return width; 
            
            }

            public double getHeight()
            {
                return height;
            }

            public double getArea()
            {
                return width * height;
            }

            public double getPerimeter() 
            {
                return 2*(width + height);
            }

            public string toString()
            {
                return $"Height: {height} Width: {width} Color: {Color} Area:{getArea()} Perimeter: {getPerimeter()}";
            }
        }

        public class Circle : AbstractShape 
        {
            public double radius;

            public void setRadius(double Radius)
            {
                radius = Radius;
            }

            public double getRadius()
            {
                return radius;
            }

            public double getArea()
            {
                return Math.PI * radius * radius;
            }

            public double getPerimeter()
            {
                return Math.PI * radius * 2;   
            }

            public string toString()
            {
                return $"Radius: {radius} Color: {Color} Area:{getArea()} Perimeter: {getPerimeter()}";
            }
        }

        public static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle();

            r1.height = 45;
            r1.width= 100;
            r2.width= 110;
            r2.height = 22.3;
            Console.WriteLine(r1.toString());
            Console.WriteLine(r2.toString());

            Circle c1 = new Circle();
            Circle c2 = new Circle();

            c1.radius = 2.5;
            c2.radius = 100;
            Console.WriteLine(c1.toString());
            Console.WriteLine(c2.toString());
        }

        
    }
}

