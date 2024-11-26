using System;

namespace Day02Solutions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem1
            //int x = 10;//intialized first operand
            //int y = 20;//intialized second operand
            //int sum = x + y;//apply binary operator that add two numbers
            //Console.WriteLine(sum);//print result of addition
            ///*
            // * ctrl+k+c ===>shortcut for comment
            // * ctrl+k+u ===>shortcut for uncomment
            // * */
            #endregion

            #region problem2
            //   int x = 10;//x must be number to perform addition
            //   int y = 8;//y must be intialized before used in addition
            //   Console.WriteLine(x + y);//Console start with capital letter 

            ////run time error : Occurs during the execution of a program. These errors cause the program to crash or terminate unexpectedly.
            //   int d1 = 10;
            //   int d2 = 0;
            //   int result = d1 / d2;
            //   Console.WriteLine(result);

            //   //logical error:Occurs when the program executes without crashing but produces incorrect or unexpected results 
            //   int x1 = 10;
            //   int y1 = 20;
            //   int sum = x1 - y1; // Logical Error: Should use '+' instead of '-'
            //   Console.WriteLine("Sum: " + sum); // Output: Sum: -10 (incorrect result)

            #endregion

            #region problem3
            //string FullName;
            //int Age;
            //decimal MonthSalary;
            //bool IsStudent;
            ////Naming conventions, such as PascalCase, are vital for writing clean, readable, and maintainable code.
            #endregion

            #region problem 4
            //int[] numbers = { 1, 2, 3 };
            //int[] numbersCopy = numbers;
            //numbers[0] = 99;
            //Console.WriteLine("Original Array (numbers): " + string.Join(", ", numbers));
            //Console.WriteLine("Copy Array (numbersCopy): " + string.Join(", ", numbersCopy));

            ////value type=> directly stored their data , stored on stack , when assign one value type to another a copy is made , changes to one variable not affect the other
            ////reference type=>store a reference (or address) to the actual data , reference is stored on the stack, but the actual object is stored on the heap
            ////assign one reference type to another, they both point to the same object in memory. Changes made through one reference affect the other
            #endregion

            #region problem 5
            //int number1 = 15;
            //int number2 = 4;
            //Console.WriteLine($"Sum = {number1 + number2}");
            //Console.WriteLine($"Subtraction = {number1 - number2}");
            //Console.WriteLine($"Product = {number1 * number2}");
            //Console.WriteLine($"Division = {((double)number1 / number2)}");
            //Console.WriteLine($"Mod = {number1 % number2}");
            #endregion

            #region problem 6
            //int a = 2, b = 7;
            //Console.WriteLine(a % b);//2 is smaller than 7, dividing 2 by 7 results in 0 quotient and a remainder of 2
            #endregion

            #region problem 7
            //int number = 11;
            //if(number >10&&number%2==0)
            //{
            //    Console.WriteLine("Valid number");
            //}else
            //    Console.WriteLine("Invalid number");
            ////logical and is short circuit if first operand is false it doesnt complete and give total result false
            ////bitwise and =>long circuit it check bit by bit ,always evaluates both operands, regardless of the first operand's value.
            #endregion

            #region problem 8
            //int num1 = int.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            ////implicit
            ////int result = num2; //give an error
            ////expilict 
            //Console.WriteLine((int)num2);
            ////A double can hold fractional values ( 12.7), while an int can only store whole numbers.
            ////Casting a double to an int truncates the decimal part ( 12.7 becomes 12), which leads to a loss of precision.
            #endregion

            #region problem 9
            //Console.Write("enter your age :");
            //string age = Console.ReadLine();
            //int IntAge = int.Parse(age);
            //if(IntAge>0)
            //{
            //    Console.WriteLine("Valid age");
            //}else
            //    Console.WriteLine("Invalid age");
            #endregion

            #region problem 10
            //int x = 10;
            //int y = 5;
            //Console.WriteLine("postfix= " + x++);//10 print then increase x=11
            //Console.WriteLine("prefix= " + (++x));//12 increase then print x=12
            //int x2 = 5;
            //int y2 = ++x2 + x2++; //6+6=12
            //Console.WriteLine(y2);
            #endregion
        }
    }
}
