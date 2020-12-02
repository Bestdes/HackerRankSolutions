using System;

namespace DayOfTheProgrammer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(dayOfProgrammer(2017));
        }

        static string dayOfProgrammer(int year)
        {
            int theNumOfTheDay = 256;
            int ry8thMDays = 243;
            int ly8thMDays = 244;
            int thisYearNum;
            DateTime date;

            if (year < 1918)
            {
                if(year % 4 == 0)
                {
                    thisYearNum = ly8thMDays;
                    date = new DateTime(year, 9, theNumOfTheDay - thisYearNum);

                    return $"{date.Day}.0{date.Month}.{year}";
                }

                thisYearNum = ry8thMDays;
                date = new DateTime(year, 9, theNumOfTheDay - thisYearNum);

                return $"{date.Day}.0{date.Month}.{year}";
            }
            if (year > 1917)
            {
                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    thisYearNum = ly8thMDays;
                    date = new DateTime(year, 9, theNumOfTheDay - thisYearNum);

                    return $"{date.Day}.0{date.Month}.{year}";
                }

                thisYearNum = ry8thMDays;
                date = new DateTime(year, 9, (theNumOfTheDay - thisYearNum));

                return $"{date.Day}.0{date.Month}.{year}";
            }

            return null;
        }
    }
}
