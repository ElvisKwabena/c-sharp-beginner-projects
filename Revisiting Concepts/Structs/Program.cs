namespace NkrumHub
{
    class program
    {
        //A struct type is a value type that is typically used to encapsulate small groups of related variables,
        //such as the coordinates of a rectangle or the characteristics of an item in an inventory.
        // The following example shows a simple struct declaration: 

        struct Book
        {
            public string title;
            public double price;
            public string description;
            public string author;
        }
        struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            Book b;
            b.title = "Test";
            b.price = 5.99;
            b.author = "David";

            Console.WriteLine(b.title);

            static void Main(string[] args)
            {
                Point p = new Point(10, 15);
                Console.WriteLine(p.x);
            }
        }
    }
}
     