namespace NkrumHub
{
    class Program
    {
        class Person
        {
            protected int Age { get; set; }
            protected string Name { get; set; }
        }
        class Student : Person
        {
            public Student(string nm)
            {
                Name = nm;
            }
            public void Speak()
            {
                Console.Write("Name: " + Name);
            }
            public static void Main(string[] args)
            {
                //would work here last
                Student s = new Student("David");
                s.Speak();

            }
        }

    }
}
