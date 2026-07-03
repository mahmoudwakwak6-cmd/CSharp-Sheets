// type casting program:-
// string str = "200";
// int res = 0;
// bool istrue = int.TryParse(str, out res);
// Console.WriteLine(res);


using System;

class Program
{
    static void Main ()
    {

        Console.WriteLine("Enter the dimensions of the shape in which you want to place the dominoes.");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int res = (x * y) / 2;
        Console.WriteLine("The maximum number of dominoes you can place is = " + res);
    }
};


