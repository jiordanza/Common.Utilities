using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGuru.FastKey.Utilities
{
    public class Method
    {
        public static T EnumParse<T>(string name) where T : struct
        {

            if (Enum.TryParse(name, true, out T en))
            {
                return en;
            }

            if (Enum.IsDefined(typeof(T), "NONE"))//case sensitive
            {
                return (T)Enum.Parse(typeof(T), "NONE", true);
            }
            else
            {
                throw new ArgumentException("No default value found for type " + typeof(T).FullName);
            }

        }

        public static bool EnumTryParse<T>(string name, out T value) where T : struct
        {

            if (Enum.TryParse(name, true, out T en))
            {
                value = en;
                return true;
            }
            else
            {
                value= default(T);
                return false;
            }
          

        }

        public static DateTime? GetIFCAParameterDateTime(string datetimeStr)
        {
            return datetimeStr != null ? DateTime.ParseExact(datetimeStr, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture) : null;
        }

        public static DateTime GetIFCAParameterDateTimeCompulsory(string datetimeStr)
        {
            return datetimeStr != null ? DateTime.ParseExact(datetimeStr, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture) : DateTime.MinValue;
        }

        public static DateTime GetEffectiveDateTime(DateTime datetime, int relativeTimeZone)
        {
            if (relativeTimeZone != 0)
            {
                return datetime + new TimeSpan(0, relativeTimeZone, 0);
            }
            else
            {
                return datetime;
            }
        }
    }
}
