using Impeller.Models.Dates;
using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Provides a collection of the dates in a date range, inclusive.
        /// Excluding optional dates.
        /// </summary>
        /// <param name="dateRange">The range to list the dates.</param>
        /// <param name="exclusions">The dates to be excluded.</param>
        /// <returns></returns>
        public static IEnumerable<DateTime> ListDays(this DateRange dateRange, IEnumerable<DateTime> exclusions = null)
        {
            List<DateTime> allDays =
                Enumerable
                .Range(0, 1 + dateRange.EndDate.Subtract(dateRange.StartDate).Days)
                .Select(offset => dateRange.StartDate.AddDays(offset))
                .ToList();

            if (exclusions != null && exclusions.Any())
            {
                allDays.RemoveAll(d => exclusions.Contains(d));
            }

            return allDays;
        }
    }
}
