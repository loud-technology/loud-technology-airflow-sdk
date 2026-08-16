
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchDagsTagsMatchMode2
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
    public static class PatchDagsTagsMatchMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchDagsTagsMatchMode2 value)
        {
            return value switch
            {
                PatchDagsTagsMatchMode2.All => "all",
                PatchDagsTagsMatchMode2.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchDagsTagsMatchMode2? ToEnum(string value)
        {
            return value switch
            {
                "all" => PatchDagsTagsMatchMode2.All,
                "any" => PatchDagsTagsMatchMode2.Any,
                _ => null,
            };
        }
    }
}