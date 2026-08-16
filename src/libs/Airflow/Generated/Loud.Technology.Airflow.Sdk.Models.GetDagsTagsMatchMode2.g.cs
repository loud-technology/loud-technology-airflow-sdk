
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDagsTagsMatchMode2
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDagsTagsMatchMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDagsTagsMatchMode2 value)
        {
            return value switch
            {
                GetDagsTagsMatchMode2.All => "all",
                GetDagsTagsMatchMode2.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDagsTagsMatchMode2? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetDagsTagsMatchMode2.All,
                "any" => GetDagsTagsMatchMode2.Any,
                _ => null,
            };
        }
    }
}