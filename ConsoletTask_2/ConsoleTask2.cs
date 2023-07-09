namespace ConsoletTask_2
{
    internal class ConsoleTask2
    {
        /*
        Write a C# Sharp program to print the result of the specified operations. Test data:
        -1 + 4 * 6
        ( 35+ 5 ) % 7
        14 + -4 * 6 / 11
        2 + 15 / 6 * 1 - 7 % 2
        Int z = (x++) + x;
        */
        static void Main(string[] args)
        {
            #region Second Task 
            int num1 = -1;
            int num2 = 4;
            int num3 = 6;

            int result1 = num1 + num2 * num3;
            Console.WriteLine($"num1 + num2 + num3 = {result1}");

            int num4 = 35;
            int num5 = 5;
            int num6 = 7;

            int result2 = (num4 + num5) % num6;
            Console.WriteLine($"(num4 + num5) % num 6 = {result2}");

            int num7 = 14;
            int num8 = -4;
            int num9 = 6;
            int num10 = 11;

            int result3 = num7 + num8 * num9 / num10;
            Console.WriteLine($"num7 + num8 * num9 / num10 = {result3}");

            int num11 = 2;
            int num12 = 15;
            int num13 = 6;
            int num14 = 1;
            int num15 = 7;
            int num16 = 2;

            int result4 = num11 + num12 / num13 * num14 - num15 % num16;
            Console.WriteLine($"num11 + num12 / num13 *num14 - num15 % num16 = {result4}");


            int x = 5;
            int z = (x++) + x;

            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Z = {z}");


            #endregion
        }
    }
}