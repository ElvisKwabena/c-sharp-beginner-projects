using System;
using System.Collections.Generic;

class Example
{
    public static void Main()
    {
        //Generic Implementations
        Stack<string> numbers = new Stack<string>();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");

        numbers.Pop();
        numbers.Count();
        numbers.Peek();


        // A stack can be enumerated without disturbing its contents.
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        
       //non-generic implementations
       Stack s = new Stack();   
       s.Push("one");
       s.Push("two");
       s.Push("three");


       s.Pop();
       s.Count();
       s.Peek();


        
    }
}