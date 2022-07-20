using System;
using System.Collections.Generic;
using System.IO;

class SolveMeFirst
{


    public static void Main(string[] args)
    {
        var a = Console.ReadLine();
        var b = Console.ReadLine();
        
        int c;
        int d;
        
        Int32.TryParse(a, out c);
        Int32.TryParse(b, out d);
    
        if (c > 0 && c <= 1000 && d > 0 && d <= 1000)
        {
            Console.WriteLine((c+d));
        }
    }
}      
