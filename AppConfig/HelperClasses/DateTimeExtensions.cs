using AppConfig.HelperClasses;
using System;
using System.Text.RegularExpressions;

namespace AppConfig.HelperClasses
{
    public static class DateTimeExtensions
    {
        public static int CalculateWeeks(this DateTime startDate, DateTime endDate)
        {
            try
            {
                var numberOfDays = startDate.CalculateDays(endDate);
                int weeks = (int)Math.Ceiling(numberOfDays / 7.0);

                if (weeks == 0)
                {
                    weeks = 1;
                }
                else if (weeks > 2)
                {
                    weeks += (weeks - 2) / 7;
                }
                return weeks;
            }
            catch (Exception)
            {
                return -99;

            }

            //HOW TO CALL
            //DateTime startDate = new DateTime(2024, 5, 1);
            //DateTime endDate = new DateTime(2024, 5, 15);

            //int numberOfWeeks = startDate.CalculateWeeks(endDate);
        }
        public static int CalculateDays(this DateTime startDate, DateTime endDate)
        {
            int numberOfDays = 0;
            try
            {
                numberOfDays = (int)(endDate - startDate).TotalDays + 1;
            }
            catch (Exception)
            {
                numberOfDays = -99;
            }
            return numberOfDays;
            //HOW TO CALL
            //DateTime startDate = new DateTime(2024, 5, 1);
            //DateTime endDate = new DateTime(2024, 5, 15);

            //int numberOfWeeks = startDate.CalculateDays(endDate);
        }
    }
}

