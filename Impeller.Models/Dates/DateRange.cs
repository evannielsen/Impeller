using System;
using System.Collections.Generic;
using System.Text;

namespace Impeller.Models.Dates
{
    /// <summary>
    /// Class to hold the information about a span of time including two dates.
    /// </summary>
    public class DateRange
    {
        protected DateRange()
        {
        }

        /// <summary>
        /// The start of the range.
        /// </summary>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// The end of the range.
        /// </summary>
        public DateTime EndDate { get; private set; }

        /// <summary>
        /// Generates a date range from two dates.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public static DateRange CreateDateRange(DateTime startDate, DateTime endDate)
        {
            if (startDate == null)
            {
                throw new ArgumentException("The start date cannot be null", nameof(startDate));
            }

            if (endDate == null)
            {
                throw new ArgumentException("The end date cannot be null", nameof(endDate));
            }

            if (endDate < startDate)
            {
                throw new ArgumentException("The start date cannot be before the end date", nameof(endDate));
            }

            return new DateRange() { StartDate = startDate, EndDate = endDate };
        }
    }
}
