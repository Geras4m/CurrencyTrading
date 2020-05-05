namespace OXR.Trading.Common.Extensions
{
    public static class StringExtensions
    {
        public static TEnum ToEnum<TEnum>(this string value, bool ignoreCase)
            where TEnum : struct
        {
            System.Enum.TryParse(value, ignoreCase, out TEnum result);

            return result;
        }
    }
}
