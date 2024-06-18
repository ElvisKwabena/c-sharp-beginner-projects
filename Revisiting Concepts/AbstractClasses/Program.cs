namespace NkrumHub
{
    class Program
    {
        abstract class Shape
        {
            public abstract void Draw();
        }
        class Circle: Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Circle Draw");
            }
        }
        }
    }
}