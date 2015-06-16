using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoNUnit
{
    public static class DateUtil
    {   
        public static int DateDiffInDays(string date1, string date2)
        {
            try
            {
                DateTime d1 = DateTime.Parse(date1);
                DateTime d2 = DateTime.Parse(date2);
                TimeSpan TimeSpan = d1 - d2;
                return Math.Abs(TimeSpan.Days);
            }
            catch (FormatException) 
            {//Fallara cuando no se pueda parsear el string
                return -1;
            }
        }

        public static bool IsLeapYear(int year)
        {
            return (year % 4) == 0;
        }

        public static string DateString(int day, int month, int year)
        {
            if (day <= 0 || day > 31)
                throw new ArgumentOutOfRangeException("Day must be between 1 and 31");
            if (month <= 0 || month > 12)
                throw new ArgumentOutOfRangeException("Month must be between 1 and 12");

            string sDay = (day < 10) ? "0" + day : day.ToString();
            string sMonth = (month < 10) ? "0" + month : month.ToString();
            string sYear = (year < 10) ? "0" + year : year.ToString();
            return sDay + "/" + sMonth + "/" + sYear;
        }

        public static TimeSpan Intervalo(string date1, string date2)
        {
            try
            {
                DateTime d1 = DateTime.Parse(date1);
                DateTime d2 = DateTime.Parse(date2);
                return d1 - d2;
            }
            catch (FormatException e)
            {
                throw e;
            }
        }

        public static DateTime? DateStringCanBeNull(int day, int month, int year)
        {
            try
            {
                return DateTime.Parse(DateString(day,month,year));
            }
            catch (FormatException)
            {
                return null;
            }
        }

    }
}
