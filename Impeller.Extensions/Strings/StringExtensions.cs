using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Impeller.Extensions.Strings
{
    public static class StringExtensions
    {
        /// <summary>
        /// Looks up a system time zone related to this string.
        /// </summary>
        /// <param name="timeZoneId"></param>
        /// <returns></returns>
        public static TimeZoneInfo ToTimeZoneInfo(this string timeZoneId)
        {
            return TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        }
    }
}
