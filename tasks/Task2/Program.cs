using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2
{
    class prog
    {
        static void Main()
        {      //1.	Write a program that allows the user to enter a number then print it.

            //Console.WriteLine("Enter a number");
            //bool isparsed =int.TryParse(Console.ReadLine(), out int nummm);
            //Console.WriteLine(nummm);
            ////2.	Write C# program that converts a string to an integer,
            //  but the string contains non-numeric characters. And mention what will happen

            //string invalidInput = "123abc";
            //bool isSuccess = int.TryParse(invalidInput, out int result);
            //if (isSuccess == false)
            //{
            //    Console.WriteLine($"conversion failed ");
            //}
            //else
            //{
            //    Console.WriteLine($" conversion occcured");
            //    Console.WriteLine($"Result Value: {result}");
            //}



            //3.	Write C# program that take two string variables and print them as one variable 

            //Console.WriteLine("enter first wword");
            //string v1=Console.ReadLine();
            //Console.WriteLine("enter second wword");
            //string v2 = Console.ReadLine();
            // string concat=v1+v2;
            //Console.WriteLine(concat);

            //4.	Write a program that calculates the simple interest given the principal amount, rate of interest, and time. 
            //Note: The formula for simple interest is Interest = (principal * rate * time) / 100.

            // Console.Write("Enter Principal Amount: ");
            //double principal= double.Parse(Console.ReadLine());

            // Console.Write("Enter Rate of Interest (%): ");
            // double rate=double.Parse(Console.ReadLine());

            // Console.Write("Enter Time (in years): ");
            // double time=double.Parse(Console.ReadLine());

            // double interest = (principal * rate * time) / 100;
            // Console.WriteLine($"Simple Interest = {interest}");

            // 5.Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms and height in meters. 
            //Note: The formula for BMI is BMI = (Weight) / (Height * Height)

            //    Console.WriteLine("Enter your weight in kilograms");
            //    double weight= double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter your hieght in kilograms");
            //    double hieght = double.Parse(Console.ReadLine());
            //    double BodyMass = (weight) / (hieght * hieght);
            //Console.WriteLine($"your body mass =\t{BodyMass}");
            ////6.	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. 
            // Note:   a.that below 10 degrees is "Just Cold"
            //         b.above 30 degrees is "Just Hot"
            //           c.anything else is "Just Good"
            //Console.Write("Enter temperature: ");
            //double.TryParse(Console.ReadLine(), out double temp);

            //string CurrentTemp = temp < 10 ? "Just Cold" : (temp > 30 ? "Just Hot" : "Just Good");
            //Console.WriteLine(CurrentTemp);

            //        7.)    Write a program that takes the date from the user and displays it in various formats using string interpolation.
            //              Ex:
            //                Today’s date : 20 , 11 , 2001
            //                Today's date : 20 / 11 / 2001
            //                Today's date : 20 – 11 – 2001
            //Console.Write("Enter Day: ");
            //int.TryParse(Console.ReadLine(), out int day);

            //Console.Write("Enter Month: ");
            //int.TryParse(Console.ReadLine(), out int month);

            //Console.Write("Enter Year: ");
            //int.TryParse(Console.ReadLine(), out int year);

            //Console.WriteLine($"Today's date : {day} , {month} , {year}");
            //Console.WriteLine($"Today's date : {day} / {month} / {year}");
            //Console.WriteLine($"Today's date : {day} – {month} – {year}");

            //      8.)   Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Example(1)
            //           Input: 12
            //           Output: Yes
            //            Example(2)
            //            Input: 9
            //            Output: No

            //Console.Write("Input: ");
            //int.TryParse(Console.ReadLine(), out int num);

            //if (num % 3 == 0 && num % 4 == 0)
            //    Console.WriteLine("Output: Yes");
            //else
            //    Console.WriteLine("Output: No");

            //       9.) -Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //         Example(1)
            //                  Input: -5
            //                  Output: negative
            //         Example(2)
            //                   Input: 10
            //                   Output: positive


            //Console.Write("Input: ");
            //int.TryParse(Console.ReadLine(), out int numb);

            //if (numb < 0)
            //    Console.WriteLine("Output: negative");
            //else
            //    Console.WriteLine("Output: positive");
            ////        10.) Write a program that takes 3 integers from the user then prints the max element and the min element.
            //        Example(1)
            //          Input: 7,8,5
            //          Output:
            //            max element = 8
            //              min element = 5
           int max = 0, min = 5;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter a number");
                int numbersss = int.Parse(Console.ReadLine());
               
                if (numbersss > max) { max = numbersss; }
                if (numbersss < min) { min = numbersss; }
            }
            Console.WriteLine(max);
            Console.WriteLine(min);


            //       11 - Write a program that allows the user to insert an integer number then check If a number is even or odd.

            Console.Write("Enter an integer: ");
            int.TryParse(Console.ReadLine(), out int numbers);

            if (numbers % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");


            //     12 - Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u)
            //     then print(vowel) otherwise print(consonant).

            Console.Write("Input: ");
            char ch = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if ("aeiou".Contains(ch))
                Console.WriteLine("Output: vowel");
            else if (char.IsLetter(ch))
                Console.WriteLine("Output: Consonant");

            //13- Write a program to input the month number and print the number of days in that month.
            Console.WriteLine("Enter month number");
            int month=int.Parse(Console.ReadLine());
            switch (month) {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine(" month days = 31");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine(" month days = 30");
                    break;
                case 2:
                    Console.WriteLine(" month days = 28 or29");
                    break;
            }
                


            /*Looping*/
            //1 - Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            Console.Write("Input: ");
            int.TryParse(Console.ReadLine(), out int n);

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + (i < n ? ", " : ""));
            }
            Console.WriteLine();

            //        2 - Write a program that allows the user to insert an integer then
            //        print a multiplication table up to 12.
            Console.Write("Input: ");
            int.TryParse(Console.ReadLine(), out int numm);

            for (int i = 1; i <= 12; i++)
            {
                Console.Write((numm * i) + " ");
            }
            Console.WriteLine();

            //  3 - Write a program that allows to user to insert number then print all even numbers between 1 to this number
            Console.Write("Input: ");
            int.TryParse(Console.ReadLine(), out int nn);

            for (int i = 2; i <= nn; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // 4- Write a program to enter marks of five subjects and calculate total, average and percentage.
            Console.Write("Enter Marks of five subjects: ");
            string[] marksInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double total = 0;
            int count = Math.Min(5, marksInput.Length);

            for (int i = 0; i < count; i++)
            {
                double.TryParse(marksInput[i], out double mark);
                total += mark;
            }

            double average = total / 5;
            double percentage = (total / 500) * 100;

            Console.WriteLine($"Total marks = {total}");
            Console.WriteLine($"Average Marks = {average}");
            Console.WriteLine($"Percentage = {percentage}");

            //5- Write a program in C# Sharp to find prime numbers within a range of numbers.

            Console.Write("Input starting number of range: ");
            int.TryParse(Console.ReadLine(), out int start);

            Console.Write("Input ending number of range: ");
            int.TryParse(Console.ReadLine(), out int end);

            Console.WriteLine($"The prime numbers between {start} and {end} are:");

            for (int i = Math.Max(2, start); i <= end; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}