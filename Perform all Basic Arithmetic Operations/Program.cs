using System;
using System.Collections.Generic;
using System.Text;
namespace Program
{
    class Program
    {
        static void Main(string[] args)///we are reading the two numbers using ‘Num1’ and ‘Num2’ variables respectively. The user will enter the operation to perform. Based on the option entered by the user, using switch case statement the arithmetic operation is performed. Hence we are displaying the output of the program.///
        {
            int Num1, Num2, result;
            char option;
            Console.Write("Enter the First Number : ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second Number : ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Main Menu");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the Operation you want to perform : ");
            option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case '1':
                    result = Num1 + Num2;
                    Console.WriteLine("The result of Addition is : {0}", result);
                    break;
                case '2':
                    result = Num1 - Num2;
                    Console.WriteLine("The result of Subtraction is : {0}", result);
                    break;
                case '3':
                    result = Num1 * Num2;
                    Console.WriteLine("The result of Multiplication is : {0}", result);
                    break;
                case '4':
                    result = Num1 / Num2;
                    Console.WriteLine("The result of Division is : {0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadLine();
        }

    }
}
///Output:
///Enter the First Number : 2
///Enter the Second Number : 2
///Main Menu
///1.	Addition
///2.	Subtraction
///3.	Multiplication
//4.	Division
///Enter the Operation you want to perform : 3
///The Result of Multiplication is : 4