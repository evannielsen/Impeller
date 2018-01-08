using Impeller.Extensions.Enums;
using Impeller.Models.Selections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Impeller.Helpers.Enums
{
    public static class EnumHelper
    {
        /// <summary>
        /// Generates a collection of the elements in an enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<Enum> GetElements<T>() where T : struct, IConvertible
        {
            return Enum.GetValues(typeof(T)).Cast<Enum>();
        }

        /// <summary>
        /// Generates a collection of the display and value for the elements in an enum.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<SelectListItem> GetSelectListItems<T>() where T : struct, IConvertible
        {
            return GetElements<T>().Select(e => new SelectListItem { Display = e.DisplayName(), Value = e.Value().ToString() });
        }
    }
}
