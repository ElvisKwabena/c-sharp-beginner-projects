using Microsoft.VisualBasic;
using System.Collections;
using System.Collections.Generic;

namespace NkrumHub
{
    class Program 
    {
        //Non-generic Implementation
        /*
        Hashtable myhashtable=new Hashtable();
        myhashtable.Add("txt","notepad.exe");
        myhashtable.Add("bmp", "paint.exe");

        foreach(DictionaryEntry de in myhashtable){
            Console.WriteLine("Key={0} , Value={1}",de.Key,de.Value);
        */

        // Create a new dictionary of strings, with string keys.
        //
        Dictionary<string, string> openWith =
            new Dictionary<string, string>();

        openWith.Add("name","Peter");
        openWith.Remove("name");


        foreach(KeyValuePair<string, string> kvp in myDictionary )
{
        Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
}
}
}