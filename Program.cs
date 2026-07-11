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
        Console.Write("welcome to sum of prime numbers program\n");
        Console.Write("enter the start point: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("enter the end point: ");
        int end = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            if (i <= 1) continue;

            bool isPrime = true;

            for (int j = 2; j <= (i / 2); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                sum += i;
            }
        }
        Console.WriteLine("the sum of prime numbers is = "+ sum);
        Console.ReadKey(true);
    }
};


