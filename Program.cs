using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace assessment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SwapTwoNos();
            //Multiply();
            //Function();
            //Four();
            //Five();
            //Temperature();
            //SumNine();
            //Ten();
            //Eleven();
            //Subject();
            Number();
            Console.ReadLine();


        }
        private static void SwapTwoNos()
        {
            Console.WriteLine("input the first number:");
            int Firstno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the second number:");
            int Secondno = Convert.ToInt32(Console.ReadLine());
            int temp = Firstno;
            Firstno = Secondno;
            Secondno = temp;
            Console.WriteLine("After Swapping");
            Console.WriteLine($"First number : {Firstno}");
            Console.WriteLine($"Secong number : {Secondno}");
        }
        private static void Multiply()
        {
            int Firstno;
            int Secondno;
            int Thirdno;
            Console.WriteLine("input the first number to multiply:");
            Firstno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the second number to multiply:");
            Secondno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input the third number to multiply:");
            Thirdno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{Firstno}*{Secondno}*{Thirdno}={Firstno * Secondno * Thirdno}");
        }
        private static void Function()
        {
            Console.Write("Input the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Input the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double addResult = num1 + num2;
            double subResult = num1 - num2;
            double mulResult = num1 * num2;
            double divResult = num1 / num2;
            double modResult = num1 % num2;

            Console.WriteLine($"Expected Output:");
            Console.WriteLine($"{num1} + {num2} = {addResult}");
            Console.WriteLine($"{num1} - {num2} = {subResult}");
            Console.WriteLine($"{num1} x {num2} = {mulResult}");
            Console.WriteLine($"{num1} / {num2} = {divResult}");
            Console.WriteLine($"{num1} mod {num2} = {modResult}");
        }
        private static void four()
        {
            Console.WriteLine("Enter the value for x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value for y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value for z:");
            double z = Convert.ToDouble(Console.ReadLine());

            double result1 = (x + y) * z;
            double result2 = x * y + y * z;

            Console.WriteLine($"Result of (x + y) * z: {result1}");
            Console.WriteLine($"Result of x * y + y * z: {result2}");
        }
        private static void Five()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} {number} {number} {number}");
            Console.WriteLine($"{number}{number}{number}{number}");
            Console.WriteLine();
        }
        private static void Temperature()
        {
            double celsius, kelvin, fahrenheit;

            Console.Write("Enter temperature in Celsius: ");
            if (double.TryParse(Console.ReadLine(), out celsius))
            {
                kelvin = celsius + 273.15;
                fahrenheit = (celsius * 9 / 5) + 32;

                Console.WriteLine($"Temperature in Kelvin: {kelvin:F2}");
                Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit:F2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        }

        private static void SumNine()
        {
            Console.Write("Enter the first integer: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            if (num1 == num2)
            {
                int result = 3 * sum;
                Console.WriteLine($"The sum of the two integers is {sum}, and their triple is {result}");
            }
            else
            {
                Console.WriteLine($"The sum of the two integers is {sum}");
            }
        }
        private static void Ten()
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double absoluteDifference = Math.Abs(num1 - num2);

            if (num1 > num2)
            {
                double result = 2 * absoluteDifference;
                Console.WriteLine($"The absolute difference between {num1} and {num2} is: {result}");
            }
            else
            {
                Console.WriteLine($"The absolute difference between {num1} and {num2} is: {absoluteDifference}");

            }
        }


        private static void Eleven()
        {
            Console.Write("Enter the number of days: ");
            int days = int.Parse(Console.ReadLine());

            int years = days / 365;
            int remainingDays = days % 365;
            int weeks = remainingDays / 7;
            int remainingDays2 = remainingDays % 7;

            Console.WriteLine($"Years: {years}");
            Console.WriteLine($"Weeks: {weeks}");
            Console.WriteLine($"Days: {remainingDays2}");
        }
        private static void Subject()
        {
            Console.Write("Enter marks in first subject: ");
            int subject1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in second subject: ");
            int subject2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter marks in third subject: ");
            int subject3 = Convert.ToInt32(Console.ReadLine());

            int totalMarks = subject1 + subject2 + subject3;
            double percentage = (totalMarks / 300.0) * 100;

            Console.WriteLine($"Total Marks: {totalMarks}");
            Console.WriteLine($"Percentage: {percentage}%");

            if (percentage < 35)
            {
                Console.WriteLine("Grade: Fail");
            }
            else if (percentage >= 35 && percentage < 45)
            {
                Console.WriteLine("Grade: Third");
            }
            else if (percentage >= 45 && percentage < 60)
            {
                Console.WriteLine("Grade: Second");
            }
            else
            {
                Console.WriteLine("Grade: First");
            }
        }
        private static void Number()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Finding maximum number
            int maxNumber = Math.Max(num1, num2);

            // Finding minimum number
            int minNumber = Math.Min(num1, num2);

            Console.WriteLine($"Maximum Number: {maxNumber}");
            Console.WriteLine($"Minimum Number: {minNumber}");
        }

    }

}


