//non-generic implementation of the arrayList first

using System.Collections;
using System.Collections.Generic;

namespace NkrumHub
{
    internal class Program
    {
        ArrayList myAL = new ArrayList(); 
        myAL.Add(3);
        myAL.Add(4);
        myAL.Add(34);
        myAL.Add("Sings");


        Console.WriteLine("Count: {0}" , myAL.Count);
    }
}