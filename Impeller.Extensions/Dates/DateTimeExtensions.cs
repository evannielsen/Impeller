using System;
using System.Collections.Generic;
using System.Text;

namespace Impeller.Extensions.Dates
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Finds the first day of the week in the past.
        /// </summary>
        /// <param name="date">The start date.</param>
        /// <param name="dayOfWeek">The day of the week to check for.</param>
        /// <returns></returns>
        public static DateTime FirstClosestDayInPast(this DateTime date, DayOfWeek dayOfWeek)
        {
            if (date.DayOfWeek == dayOfWeek)
            {
                return date;
            }

            DateTime workingDate = date;

            while (workingDate.DayOfWeek != dayOfWeek)
            {
                workingDate.AddDays(-1);
            }

            return workingDate;
        }

        /// <summary>
        /// Determines of the time is between 2 times in a day.
        /// </summary>
        /// <param name="date">The date to check.</param>
        /// <param name="startTime">The starting time of the day.</param>
        /// <param name="endTime">The ending time of the day.</param>
        /// <returns></returns>
        public static bool IsDateInTimeRange(this DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            var timeOfDay = date.TimeOfDay;

            if (startTime <= endTime)
            {
                return timeOfDay > startTime && timeOfDay < endTime;
            }
            else
            {
                return timeOfDay > startTime || timeOfDay < endTime;
            }
        }
    }
}
