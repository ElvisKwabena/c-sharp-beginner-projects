namespace NkrumHub
{
    class Program
    {
        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Base Draw");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Circle Draw"); 

            }
        }
        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rectangle Draw");
            }
        }

        static void Main(string[] args)
        {
            Shape c = new Circle();
            c.Draw();

            Shape r = new Rectangle();
            r.Draw();
        }
    }
}
