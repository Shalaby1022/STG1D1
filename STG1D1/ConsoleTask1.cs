using System.Security.Cryptography.X509Certificates;

namespace STG1D1
{
    internal class ConsoleTask1
    {
        static void Main(string[] args)
        {
            /*
            Write a C# Sharp program to print the sum of two numbers. //string interpolation
            */

            #region First_Task

            Console.WriteLine("Enter the first number:");
            int Num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int Num2 = int.Parse(Console.ReadLine());

            int Sum = Num1 + Num2;

            Console.WriteLine($"The sum of {Num1} and {Num2} is: {Sum}");


        

            #endregion

           

            








        }

    }

}