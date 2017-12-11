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

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

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
