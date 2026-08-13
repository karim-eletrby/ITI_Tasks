using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        //1
        int[] Q1 = { 1, 2, 3, 8, 9 };
        Console.Write("Sum: ");
        Console.WriteLine(Q1.Sum());

        //2
        Console.Write("Maximum: ");
        Console.WriteLine(Q1.Max());
        Console.Write("Minimum: ");
        Console.WriteLine(Q1.Min());

        //3
        string[] Q3 = { "apple", "banana", "cherry", "date" };
        Console.WriteLine(Q3[0]);

        Array.Reverse(Q3);
        Console.WriteLine(Q3[0]);

        //4


        /* int[,] Q4 = new int[3, 3];
         for (int i = 0; i < 3; i++)
         {
             for (int j = 0; j < 3; j++)
             {
                 Q4[i, j] = int.Parse(Console.ReadLine());
             }
         }

         int[,] Q4_2 = new int[3, 3];
         //Q4.CopyTo(Q4_2, 0);
         for (int i = 0; i < 3; i++)
         {
             for (int j = 0; j < 3; j++)
             {
                 Console.Write(Q4_2[i, j] + " ");
             }
             Console.WriteLine();
         }*/





        //5
        int[] Q5 = { 88, 97, 4, 66, 0, 1 };
        Console.WriteLine(Q5[0]);
        Array.Reverse(Q5);
        Console.WriteLine(Q5[0]);



        //6

        int e = 7;
        int r = 6;
        VSwap(e, r);


        //7
        int x = 8;
        int y = 130;
        Swap(ref x, ref y);



        //8
        sumsub(1, 2, 3, 4);


        //9
        Console.WriteLine(isPrime(7));

        //10
        Console.WriteLine(fact(r));

        //11
        Console.WriteLine(replace("wanna cry", 'c', 't'));

    }
    public static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }


    public static void VSwap(int A, int B)
    {
        int temp = A;
        A = B;
        B = temp;
    }


    public static void sumsub(int a, int b, int c, int d)
    {
        Console.WriteLine(a + b + c + d);
        Console.WriteLine(a - b - c - d);
    }
    public static int fact(int m)
    {
        while (m > 1)
        {
            return m * fact(m - 1);
        }
        return 1;
    }
    public static bool isPrime(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public static string replace(string str, char oldChar, char newChar)
    {
        return str.Replace(oldChar, newChar);
    }


}


