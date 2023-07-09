namespace LoopsandFunction
{
    internal class LoopandFunctionTask
    {
        /*
        your birth date
            plz enter year
            2000
            plz enter month
            2
            plz enter day
            30
            plz enter day
            32
            plz enter day
            28
            you're 20 years, 4 months and 13 days
            month   1,3,5,7,8,10,12        31
            month   4,6,9,11           	30
            month   2          		28,29

            Validate year, month and day using` function

        */
        #region Loops&Function Task
        static bool ValidateDate(int year, int month, int day)
        {
            // Check if the year is valid
            if (year < 1)
            {
                return false;
            }

            // Check if the month is valid
            if (month < 1 || month > 12)
            {
                return false;
            }

            // Check if the day is valid
            int maxDays = DateTime.DaysInMonth(year, month);
            if (day < 1 || day > maxDays)
            {
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
                Console.WriteLine("Please enter the year:");
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the month:");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the day:");
                int day = int.Parse(Console.ReadLine());

                if (ValidateDate(year, month, day))
                {
                    Console.WriteLine("Date is valid!");
                }
                else
                {
                    Console.WriteLine("Date is invalid!");
                }
            }
        #endregion
    }
}
