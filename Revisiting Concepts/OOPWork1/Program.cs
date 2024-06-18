using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace NkruHub
{
    class program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public int page_count { get; set; }
            public double price { get; set; }
        }

        class Person
        {
            public string FirstName
            {
                get
                {
                    return FirstName;
                }

                set
                {
                    FirstName = value;
                }
            }
            public string LastName
            {
                get
                {
                    return LastName;
                }
                set
                {
                    LastName = value;
                }
            }
            public int Age
            {
                get
                {
                    return Age;
                }

                set
                {
                    Age = value;
                }
            }
            public string Gender
            {
                get
                {
                    return Gender;
                }

                set
                {
                    Gender = value;
                }

            }

            class Driver
            {
                Person p1 = new Person();
                Person p2 = new Person();

        }


        }
        public string PhoneNumber
            {
                get
                {
                    return PhoneNumber;

                }
                set
                {
                    PhoneNumber = value;
                }

            }
        
               
            public static void Main(string[] args)
            {
                Book b1 = new Book();
                Book b2 = new Book();

                Console.WriteLine(b1.Author);
                Console.WriteLine(b2.price);
                Console.WriteLine(b2.ISBN);
                Console.WriteLine(b2.page_count);
            }


        
    }
}
