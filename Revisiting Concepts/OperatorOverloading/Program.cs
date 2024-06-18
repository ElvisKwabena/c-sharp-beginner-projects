namespace NkrumHub
{
    class Program
    {
        class Box
        {
            public int Height {get; set;}
            public int Width {get; set;}

            public Box(int h, int w)
            {
                Height = h;
                Width = w;
            }
            public static Box operator+ (Box box1, Box box2)
            {
                int h = box1.Height + box2.Height;
                int w = box1.Width + box2.Width;

                Box res = new Box(h, w);
                return res;

            }
        }
        public static void Main(string[] args)
        {
            Box b1 = new Box(14, 3);
            Box b2 = new Box(5, 7);

            Box b3 = b1 + b2;

            Console.WriteLine(b3.Width);
            Console.WriteLine(b3.Height);
        }
    }

}