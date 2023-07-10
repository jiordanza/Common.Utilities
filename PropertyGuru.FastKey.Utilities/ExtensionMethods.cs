using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PropertyGuru.FastKey.Utilities
{
    public static partial class ExtensionMethods
    {
        public static bool IsNullOrEmpty(this JToken token)
        {
            return (token == null) ||
                   (token.Type == JTokenType.Array && !token.HasValues) ||
                   (token.Type == JTokenType.Object && !token.HasValues) ||
                   (token.Type == JTokenType.String && token.ToString().Trim() == String.Empty) ||
                   (token.Type == JTokenType.Null);
        }

        public static bool IsNull(this JToken token)
        {
            return (token == null) || (token.Type == JTokenType.Null);
        }

        public static string ToStringWithTrim(this JToken token)
        {
            return token.ToString().Trim();
        }
        public static int IndexOf(this StringBuilder sb, string value, int startIndex, bool ignoreCase)
        {
            int index;
            int length = value.Length;
            int maxSearchLength = (sb.Length - length) + 1;

            if (ignoreCase)
            {
                for (int i = startIndex; i < maxSearchLength; ++i)
                {
                    if (Char.ToLower(sb[i]) == Char.ToLower(value[0]))
                    {
                        index = 1;
                        while ((index < length) && (Char.ToLower(sb[i + index]) == Char.ToLower(value[index])))
                            ++index;

                        if (index == length)
                            return i;
                    }
                }

                return -1;
            }

            for (int i = startIndex; i < maxSearchLength; ++i)
            {
                if (sb[i] == value[0])
                {
                    index = 1;
                    while ((index < length) && (sb[i + index] == value[index]))
                        ++index;

                    if (index == length)
                        return i;
                }
            }

            return -1;
        }

        public static IEnumerable<TResult> TakeIfNotNull<TResult>(this IEnumerable<TResult> source, int? count)
        {
            return !count.HasValue ? source : source.Take(count.Value);
        }
        public static string ToXML(this List<int> value)
        {
            var doc = new XDocument(new XElement("list"));
            var root = doc.Root;
            foreach (int item in value)
            {
                if (item > 0)
                    root.Add(new XElement("y", new XAttribute("i", item)));
            }
            return doc.ToString();
        }

        public static string ToXML(this List<Guid> value)
        {
            var doc = new XDocument(new XElement("list"));
            var root = doc.Root;
            foreach (Guid item in value)
            {
                if (item != Guid.Empty)
                    root.Add(new XElement("y", new XAttribute("i", item)));
            }
            return doc.ToString();
        }

        public static string Description(this Enum value)
        {
            var enumType = value.GetType();
            var field = enumType.GetField(value.ToString());
            if (field != null)
            {
                var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute),
                                                            false);
                return attributes.Length == 0
                    ? value.ToString()
                    : ((DescriptionAttribute)attributes[0]).Description;
            }
            else
            {
                return string.Empty;
            }
        }

        //public static string Description(this Enum value, string resourceSet)
        //{
        //    var enumType = value.GetType();
        //    var field = enumType.GetField(value.ToString());
        //    if (field != null)
        //    {
        //        var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute),
        //                                                    false);

        //        var localeIdAttr = field.GetCustomAttributes(typeof(LocaleIdAttribute),
        //                                                    false);

        //        if (localeIdAttr.Length == 0)
        //        {
        //            return attributes.Length == 0
        //            ? value.ToString()
        //            : ((DescriptionAttribute)attributes[0]).Description;
        //        }
        //        else
        //        {
        //            return L10n.T(((LocaleIdAttribute)localeIdAttr[0]).TranslationKeyword, resourceSet);
        //        }

        //    }
        //    else
        //    {
        //        return string.Empty;
        //    }
        //}

        //public static string DescriptionCrm(this Enum value, string resourceSet)
        //{
        //    var enumType = value.GetType();
        //    var field = enumType.GetField(value.ToString());
        //    if (field != null)
        //    {
        //        var attributes = field.GetCustomAttributes(typeof(CrmCodeDescAttribute),
        //                                                    false);

        //        var localeIdAttr = field.GetCustomAttributes(typeof(LocaleIdAttribute),
        //                                                    false);

        //        if (localeIdAttr.Length == 0)
        //        {
        //            return attributes.Length == 0
        //            ? value.ToString()
        //            : ((CrmCodeDescAttribute)attributes[0]).Desc;
        //        }
        //        else
        //        {
        //            return L10n.T(((LocaleIdAttribute)localeIdAttr[0]).TranslationKeyword, resourceSet);
        //        }

        //    }
        //    else
        //    {
        //        return string.Empty;
        //    }
        //}

        public static T GetAttribute<T>(this Enum value)
        {
            var enumType = value.GetType();
            var field = enumType.GetField(value.ToString());
            if (field != null)
            {
                return (T)field.GetCustomAttributes(typeof(T), false).FirstOrDefault();
            }
            else
            {
                return default(T);
            }
        }
        public static string ValueString(this Enum value)
        {
            return ((int)Enum.ToObject(value.GetType(), value)).ToString();

        }

        public static Dictionary<string, object> AsDictionary(this object source, BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
        {
            return source.GetType().GetProperties(bindingAttr).ToDictionary
            (
                propInfo => propInfo.Name,
                propInfo => propInfo.GetValue(source, null)
            );

        }
        public static TValue GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dict, TKey key)
        {
            return dict.TryGetValue(key, out var value) ? value : default(TValue);
        }

        [Description("Returns null if string value is not Guid")]
        public static Guid? TryGuidParse(this string value)
        {
            Guid result;
            if (Guid.TryParse(value, out result))
            {
                return result;
            }
            return null;
        }
        public static Object GetPropValue(this Object obj, String name)
        {
            foreach (String part in name.Split('.'))
            {
                if (obj == null) { return null; }

                Type type = obj.GetType();
                PropertyInfo info = type.GetProperty(part, BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase);

                if (info == null) { return null; }

                obj = info.GetValue(obj, null);


            }
            return obj;
        }

        public static Object GetPropValue(this Object obj, String name, out bool isReadOnly)
        {
            isReadOnly = false;
            foreach (String part in name.Split('.'))
            {
                if (obj == null) { return null; }

                Type type = obj.GetType();
                PropertyInfo info = type.GetProperty(part, BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase);

                if (info == null) { return null; }
                isReadOnly = !info.CanWrite;
                obj = info.GetValue(obj, null);


            }
            return obj;
        }

        public static T GetPropValue<T>(this Object obj, String name)
        {
            Object retval = GetPropValue(obj, name);
            if (retval == null) { return default(T); }

            // throws InvalidCastException if types are incompatible
            return (T)retval;
        }

        public static T GetPropValue<T>(this Object obj, String name, out bool isReadonly)
        {
            isReadonly = false;
            Object retval = GetPropValue(obj, name, out isReadonly);
            if (retval == null) { return default(T); }

            // throws InvalidCastException if types are incompatible
            return (T)retval;
        }

        public static PropertyInfo GetPropDataInfo(this Object obj, String name)
        {
            if (obj == null) { return null; }

            string[] parts = name.Split('.');

            for (int i = 0; i < parts.Length - 1; i++)
            {
                if (obj != null)
                {
                    PropertyInfo info = obj.GetType().GetProperty(parts[i], BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase);

                    if (info == null) { return null; }

                    obj = info.GetValue(obj, null);
                }
            }

            PropertyInfo returnInfo = obj.GetType().GetProperty(parts.Last(), BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase);

            return returnInfo;
        }

        //public static Boolean SetPropValue(this object obj, string name, object value)
        //{
        //    string[] parts = name.Split('.');
        //    bool byPassCheck = false;
        //    for (int i = 0; i < parts.Length - 1; i++)
        //    {
        //        if (obj != null)
        //        {
        //            PropertyInfo info = obj.GetType().GetProperty(parts[i], BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase);
        //            obj = info.GetValue(obj, null);
        //        }
        //    }

        //    PropertyInfo propertyToSet = obj.GetType().GetProperty(parts.Last(), BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase);
        //    bool isReadOnly = !propertyToSet.CanWrite;
        //    if (isReadOnly)
        //    {
        //        return false;
        //    }
        //    object oldValue = propertyToSet.GetValue(obj, null);

        //    if (oldValue == null && value == null) return false;

        //    if (oldValue == null && value != null) byPassCheck = true;


        //    //find the property type
        //    Type propertyType = propertyToSet.PropertyType;

        //    //Convert.ChangeType does not handle conversion to nullable types
        //    //if the property type is nullable, we need to get the underlying type of the property
        //    var targetType = Method.IsNullableType(propertyToSet.PropertyType) ? Nullable.GetUnderlyingType(propertyToSet.PropertyType) : propertyToSet.PropertyType;

        //    //for string type, treat null and empty as equal
        //    if (targetType == typeof(string))
        //    {
        //        if ((oldValue == null || string.IsNullOrWhiteSpace(oldValue.ToString())) && (value == null || string.IsNullOrWhiteSpace(value.ToString())))
        //        {
        //            return false;
        //        }
        //    }

        //    //Returns an System.Object with the specified System.Type and whose value is
        //    //equivalent to the specified object.
        //    if (value != null)
        //    {
        //        value = Convert.ChangeType(value, targetType);
        //    }

        //    //Set the value of the property
        //    propertyToSet.SetValue(obj, value, null);

        //    if (!byPassCheck)
        //    {
        //        object newValue = propertyToSet.GetValue(obj, null);
        //        if (oldValue.Equals(newValue)) return false;
        //    }

        //    return true;
        //}

        public static bool HasProperty(this object obj, string name)
        {
            Type type = obj.GetType();
            return type.GetProperty(name, BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.IgnoreCase) != null;
        }

        public static bool IsNumericType(this object o)
        {
            switch (Type.GetTypeCode(o.GetType()))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsBooleanType(this object o)
        {
            switch (Type.GetTypeCode(o.GetType()))
            {
                case TypeCode.Boolean:
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsGuidType(this object o)
        {
            if (o.GetType() == typeof(Guid))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static decimal? ToDecimal(this string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                decimal result;
                if (decimal.TryParse(value, out result))
                {
                    return result;
                }

            }
            return default(decimal?);

        }

        public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
        {
            foreach (var i in ie)
            {
                action(i);
            }
        }

        public static string FormatWith(this string value, params object[] args)
        {
            try
            {
                return string.Format(value, args);
            }
            catch (Exception)
            {
                return "LOCALIZATION_FORMAT_ERROR";
            }

        }

        public static string ToYesNoString(this bool value)
        {
            return value ? "Yes" : "No";
        }

        public static string TrimNullAsEmpty(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }
            else
            {
                return value.Trim();
            }

        }
        /// <summary>
        /// Returns 0 if not valid
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int TryParseToInt(this string value)
        {
            int result;
            return int.TryParse(value, out result) ? result : 0;
        }

        public static int TryParseToInt(this string value, int defaultValue)
        {
            int result;
            return int.TryParse(value, out result) ? result : defaultValue;
        }

        public static int? TryParseToIntNullable(this string value)
        {
            int result;
            if (int.TryParse(value, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public static int? TryGetIntValue(this object obj)
        {
            int? _val = null;
            if (obj == null) return _val;
            try
            {
                _val = Convert.ToInt32(obj);
            }
            finally
            { }
            return _val;
        }

        public static T Clone<T>(this T original)
        {
            var serialized = JsonConvert.SerializeObject(original);
            return JsonConvert.DeserializeObject<T>(serialized);
        }
 
        public static DateTime GetDBTime(this DateTime time, int relativeTimeZone)
        {
            if (relativeTimeZone != 0)
            {
                return time - new TimeSpan(0, relativeTimeZone, 0);
            }
            else
            {
                return time;
            }


        }

        /// <summary>
        /// This method returns local time according to the relative time zone value
        /// </summary>
        /// <param name="gt"></param>
        /// <param name="relativeTimeZone"></param>
        /// <returns></returns>
        public static DateTime GetLocalTime(this DateTime time, int relativeTimeZone)
        {
            if (relativeTimeZone != 0 && time != DateTime.MinValue)
            {
                return time + new TimeSpan(0, relativeTimeZone, 0);
            }
            else
            {
                return time;
            }


        }

        public static DateTime? GetLocalTime(this DateTime? time, int relativeTimeZone)
        {
            if (time != null && time != DateTime.MinValue)
            {
                return time.Value.GetLocalTime(relativeTimeZone);
            }
            return time;
        }

        public static string ToUniversalTimeString(this DateTime time)
        {
            return time.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
        }

        public static DateTime UtcToSgt(this DateTime utcDateTime)
        {
            TimeZoneInfo timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(utcDateTime, timeZoneInfo);
        }

        //public static bool IsSoldOrSPA(this SharedConstant.UNIT_STATUS unitStatus)
        //{
        //    bool booResult = false;
        //    switch (unitStatus)
        //    {
        //        case SharedConstant.UNIT_STATUS.SOLD:
        //        case SharedConstant.UNIT_STATUS.SPA_SIGNED:
        //        case SharedConstant.UNIT_STATUS.SPA_STAMPED:
        //            booResult = true;
        //            break;
        //        default:
        //            booResult = false;
        //            break;
        //    }
        //    return booResult;
        //}
        //public static bool IsContractOrSPA(this SharedConstant.BOOKING_STATUS bookStatus)
        //{
        //    bool booResult = false;
        //    switch (bookStatus)
        //    {
        //        case SharedConstant.BOOKING_STATUS.CONTRACT:
        //        case SharedConstant.BOOKING_STATUS.SPA_SIGNED:
        //        case SharedConstant.BOOKING_STATUS.SPA_STAMPED:
        //            booResult = true;
        //            break;
        //        default:
        //            booResult = false;
        //            break;
        //    }
        //    return booResult;
        //}
        //public static bool IsSPASignedOrSPAStamped(this SharedConstant.BOOKING_STATUS bookStatus)
        //{
        //    bool booResult = false;
        //    switch (bookStatus)
        //    {
        //        case SharedConstant.BOOKING_STATUS.SPA_SIGNED:
        //        case SharedConstant.BOOKING_STATUS.SPA_STAMPED:
        //            booResult = true;
        //            break;
        //        default:
        //            booResult = false;
        //            break;
        //    }
        //    return booResult;
        //}
        //public static bool IsNoneOrCancel(this SharedConstant.BOOKING_SUB_STATUS bookSubStatus)
        //{
        //    bool booResult = false;
        //    switch (bookSubStatus)
        //    {
        //        case SharedConstant.BOOKING_SUB_STATUS.NONE:
        //        case SharedConstant.BOOKING_SUB_STATUS.PENDING_REQ_CANCEL:
        //            booResult = true;
        //            break;
        //        default:
        //            booResult = false;
        //            break;
        //    }
        //    return booResult;
        //}

        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> source) => source ?? Enumerable.Empty<T>();

        public static bool TryParse(this string strInput, out JToken output)
        {
            if (String.IsNullOrWhiteSpace(strInput))
            {
                output = null;
                return false;
            }
            strInput = strInput.Trim();
            if ((strInput.StartsWith("{") && strInput.EndsWith("}")) || //For object
                (strInput.StartsWith("[") && strInput.EndsWith("]"))) //For array
            {
                try
                {
                    output = JToken.Parse(strInput);
                    return true;
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    //LogError(jex);
                    output = null;
                    return false;
                }
                catch (Exception ex) //some other exception
                {
                    //LogError(ex);
                    output = null;
                    return false;
                }
            }
            else
            {
                output = null;
                return false;
            }
        }


    }
}
