using System;
using System.Collections.Generic;
using System.Text;

namespace Impeller.Extensions.Dates
{
    public static class DateTimeOffsetExtensions
    {
        /// <summary>
        /// Converts an offset time to the specified zone.
        /// </summary>
        /// <param name="timeOffset">The time offset.</param>
        /// <param name="zone">The destination time zone.</param>
        /// <returns></returns>
        public static DateTimeOffset ConvertToZone(this DateTimeOffset timeOffset, TimeZoneInfo zone)
        {
            TimeSpan offset = zone.GetUtcOffset(timeOffset);
            return timeOffset.ToOffset(offset);
        }
    }
}
