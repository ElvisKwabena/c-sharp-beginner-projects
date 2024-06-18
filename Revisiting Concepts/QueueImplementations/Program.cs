using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        Queue<string> numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        numbers.Enqueue("five");

        numbers.Dequeue();
        numbers.Peek();
        numbers.Count();


        // A queue can be enumerated without disturbing its contents.
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        
    }
}

