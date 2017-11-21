using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Impeller.Extensions.Enums
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets the display name using the <see cref="DisplayNameAttribute"> DisplayNameAttribute</see>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string DisplayName(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null)
            {
                return value.ToString();
            }

            Attribute baseAttribute = fieldInfo.GetCustomAttribute(typeof(DisplayNameAttribute));

            if (baseAttribute == null)
            {
                return value.ToString();
            }

            DisplayNameAttribute attribute = baseAttribute as DisplayNameAttribute;

            if (attribute == null)
            {
                return value.ToString();
            }

            return attribute.DisplayName;
        }

        /// <summary>
        /// Gets the description using the <see cref="DescriptionAttribute">DescriptionAttribute</see>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Description(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            if (fieldInfo == null)
            {
                return value.ToString();
            }

            Attribute baseAttribute = fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute));

            if (baseAttribute == null)
            {
                return value.ToString();
            }

            DescriptionAttribute attribute = baseAttribute as DescriptionAttribute;

            return attribute == null ? value.ToString() : attribute.Description;
        }

        /// <summary>
        /// Gets the value of an enumeration.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object Value(this Enum value)
        {
            return Convert.ChangeType(value, value.GetTypeCode());
        }
    }
}
