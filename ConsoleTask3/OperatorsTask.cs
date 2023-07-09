namespace ConsoleTask3
{
    internal class OperatorsTask
    {
        /*
        Write a C# program to print the comparing results between three integer values.

        */

        static void Main(string[] args)
        {
            #region Third Task Operators

            Console.WriteLine("Please enter the first number:");
            int X = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int Y = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third number:");
            int Z = int.Parse(Console.ReadLine());


            Console.WriteLine("Comparison Results:");

            // Compare X and Y
            if (X > Y)
            {
                Console.WriteLine(X + " is greater than " + Y);
            }
            else if (X < Y)
            {
                Console.WriteLine(X + " is less than " + Y);
            }
            else
            {
                Console.WriteLine(X + " is equal to " + Y);
            }

            // Compare X and Z
            if (X > Z)
            {
                Console.WriteLine(X + " is greater than " + Z);
            }
            else if (X < Z)
            {
                Console.WriteLine(X + " is less than " + Z);
            }
            else
            {
                Console.WriteLine(X + " is equal to " + Z);
            }

            // Compare Y and Z
            if (Y > Z)
            {
                Console.WriteLine(Y + " is greater than " + Z);
            }
            else if (Y < Z)
            {
                Console.WriteLine(Y + " is less than " + Z);
            }
            else
            {
                Console.WriteLine(Y + " is equal to " + Z);

            }



            // Another solution using && and || operators 
            Console.WriteLine();
            Console.WriteLine("Comparison using && and ||");
           

            if (X > Y && X > Z)
            {
                Console.WriteLine("The first number is the largest.");
            }
            else if (Y > X && Y > Z)
            {
                Console.WriteLine("The second number is the largest.");
            }
            else if (Z > X && Z > Y)
            {
                Console.WriteLine("The third number is the largest.");
            }
            else
            {
                Console.WriteLine("Two or more numbers are equal or there was an error.");
            }


            #endregion
        }
    }
}