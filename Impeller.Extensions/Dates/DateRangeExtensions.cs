using Impeller.Models.Dates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Impeller.Extensions.Dates
{
    /// <summary>
    /// Extensions for the <see cref="DateRange">DateRange</see> object.
    /// </summary>
    public static class DateRangeExtensions
    {
        /// <summary>
        /// Determines if a date range over laps another date range.
        /// </summary>
        /// <param name="initial"></param>
        /// <param name="comparator"></param>
        /// <returns></returns>
        public static bool Overlaps(this DateRange initial, DateRange comparator)
        {
            return initial.StartDate <= comparator.EndDate && comparator.StartDate <= initial.EndDate;
        }

        /// <summary>
        /// Determines of a date time is within a date range.
        /// </summary>
        /// <param name="range"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool DateIsInRange(this DateRange range, DateTime date)
        {
            return range.StartDate >= date && range.EndDate <= date;
        }
    }
}
