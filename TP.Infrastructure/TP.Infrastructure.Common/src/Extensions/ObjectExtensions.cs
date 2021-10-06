using System;

namespace TP.Infrastructure.Common.Extensions
{
    public static class ObjectExtensions
    {
        public static T As<T>(this object instance) where T : class
        {
            return instance as T;
        }

        public static bool Is<T>(this object instance)
        {
            return instance is T;
        }

        public static TEnum ToEnum<TEnum>(this string @enum) where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            return (TEnum)Enum.Parse(typeof(TEnum), @enum);
        }

        public static TEnum? TryToEnum<TEnum>(this string @enum) where TEnum : struct, IComparable, IFormattable, IConvertible
        {
            try
            {
                return @enum.ToEnum<TEnum>();
            }
            catch
            {
                return null;
            }
        }
    }
}
