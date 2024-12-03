using System;

namespace Day04_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem 1
            ////1.initialize using new int[size]
            //int[] numbers1 = new int [5];
            //for(int i=0;i<5;i++)
            //{
            //    numbers1[i] = i+1;
            //}
            //foreach(int num in numbers1 )
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("------------------------------------------");
            ////3.initialize using array syntax sugar
            //int[] numbers2 = new int[] { 1, 2, 3, 4, 5 };
            //foreach (int num in numbers2)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("------------------------------------------");
            ////2.initialize using list
            //int[] numbers3 = { 1, 2, 3, 4, 5 };
            //foreach (int num in numbers3)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine("------------------------------------------");
            ////IndexOutOfRangeException
            //try
            //{
            //    int number = numbers1[7];
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region problem 2
            //shallow copy
            //int[] arr1 = { 1, 2, 3, 4 };
            //int[] arr2 = new int[4];
            //arr2 = arr1;
            //arr2[0] = 20;
            //Console.WriteLine("Shallow copy demonstrating:");
            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);

            ////deep copy
            //arr2 = (int[])arr1.Clone();
            //arr2[0] = 10;//arr1[0]=20
            //Console.WriteLine("Deep copy demonstrating:");
            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);
            #endregion

            #region problem 3
            //int[,] grades = new int[3, 3];
            //Console.WriteLine("Enter grade for each student for 3 subjects");
            //for (int student = 0; student < grades.GetLength(0); student++)
            //{
            //    for (int subject = 0; subject < grades.GetLength(1); subject++)
            //    {
            //        Console.Write($"Enter grade for Student {student + 1}, Subject {subject + 1}: ");
            //        grades[student, subject] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nGrades for each student:");
            //for (int student = 0; student < grades.GetLength(0); student++)
            //{
            //    Console.WriteLine($"Student :{student + 1}");
            //    for (int subject = 0; subject < grades.GetLength(1); subject++)
            //    {
            //        Console.WriteLine(grades[student, subject]);
            //    }
            //}
            #endregion

            #region problem 4
            //int[] numbers = new int[] { 3, 1, 5, 8, 4, 9, 2 };
            //Array.Sort(numbers);
            //Console.WriteLine("Sort array elements in ascending order :");
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //Array.Reverse(numbers);
            //Console.WriteLine("Reverse array elements :");
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine($"Return index of an element : {Array.IndexOf(numbers,9)}");//0
            //int[] arr2=new int[7];
            //Array.Copy(numbers, arr2, 7);
            //Console.WriteLine("Copied array :");
            //foreach (var num in arr2)
            //{
            //    Console.WriteLine(num);
            //}

            //Array.Clear(arr2);
            //Console.WriteLine("Cleared array :");
            //foreach (var num in arr2)
            //{
            //    Console.WriteLine(num);//00000000
            //}
            #endregion

            #region problem 5
            //int[] numbers = new int[] { 3, 5, 1, 2, 3, 3 };
            ////for loop
            //for (int i=0;i<numbers .Length;i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            ////foreach
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            ////While Loop
            //int index = numbers.Length - 1; // Start from the last index
            //while (index >= 0)
            //{
            //    Console.Write(numbers[index] + " ");
            //    index--;  
            //}
            #endregion

            #region problem 6
            //int Number;
            //bool isOdd;
            //do
            //{
            //    Console.WriteLine("Enter odd Number: ");

            //    isOdd = int.TryParse(Console.ReadLine(), out Number);
            //} while (isOdd && Number%2!=0 );
            #endregion

            #region problem 7
            //int[,] matrix = { {1,2,3 }, {4,5,6 }, {7,8,9 } };
            //for(int i=0;i<matrix.GetLength(0);i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(0); j++)
            //    {
            //        Console.Write($"{matrix[i, j],3}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region problem 8
            //Console.Write("Enter a month number (1-12): ");
            //string input = Console.ReadLine();

            //// Validate input
            //if (!int.TryParse(input, out int month) || month < 1 || month > 12)
            //{
            //    Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
            //    return;
            //}

            //// Determine month name using if-else
            //string monthName;
            //if (month == 1) monthName = "January";
            //else if (month == 2) monthName = "February";
            //else if (month == 3) monthName = "March";
            //else if (month == 4) monthName = "April";
            //else if (month == 5) monthName = "May";
            //else if (month == 6) monthName = "June";
            //else if (month == 7) monthName = "July";
            //else if (month == 8) monthName = "August";
            //else if (month == 9) monthName = "September";
            //else if (month == 10) monthName = "October";
            //else if (month == 11) monthName = "November";
            //else monthName = "December";

            //Console.WriteLine($"Using if-else: The month is {monthName}");

            //// Determine month name using switch
            //string monthName2;
            //switch (month)
            //{
            //    case 1:
            //        monthName2 = "January";
            //        break;
            //    case 2:
            //        monthName2 = "February";
            //        break;
            //    case 3:
            //        monthName2 = "March";
            //        break;
            //    case 4:
            //        monthName2 = "April";
            //        break;
            //    case 5:
            //        monthName2 = "May";
            //        break;
            //    case 6:
            //        monthName2 = "June";
            //        break;
            //    case 7:
            //        monthName2 = "July";
            //        break;
            //    case 8:
            //        monthName2 = "August";
            //        break;
            //    case 9:
            //        monthName2 = "September";
            //        break;
            //    case 10:
            //        monthName2 = "October";
            //        break;
            //    case 11:
            //        monthName2 = "November";
            //        break;
            //    case 12:
            //        monthName2 = "December";
            //        break;
            //    default:
            //        monthName2 = "Invalid month"; // Should never reach here due to validation
            //        break;
            //}

            //Console.WriteLine($"Using Switch : The month is {monthName2}");
            #endregion

            #region problem 9
            //int[] numbers = new int[] { 5, 1, 8, 2, 4, 9, 7, 10 ,4};
            //Array.Sort(numbers);//1244578910
            //Console.WriteLine($"index of first occurencethis element is {Array.IndexOf(numbers, 4)}");//2 first time it occure
            //Console.WriteLine($"index of last occurence of this element is {Array.LastIndexOf(numbers, 4)}");//3
            #endregion

            #region problem 10
            //int[] numbers = new int[] { 3, 4, 6, 7, 7 };
            ////sum using for loop
            //int sum = 0;
            //for(int i=0;i<numbers .Length;i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine($"Sum using for loop :  {sum}");
            //sum = 0;
            //foreach (var number in numbers)
            //{
            //    sum += number;
            //}
            //Console.WriteLine($"Sum using foreach :  {sum}");
            #endregion

            #region problem 11
            Console.Write("Enter a number (1-7) to get the corresponding day: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            {
                // Convert the integer to the corresponding enum value
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayNumber.ToString());

                // Print the corresponding day
                Console.WriteLine($"The day corresponding to {dayNumber} is {day}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            }
            #endregion
        }
    }
}
