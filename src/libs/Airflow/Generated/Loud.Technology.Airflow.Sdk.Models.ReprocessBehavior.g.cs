
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Internal enum for setting reprocess behavior in a backfill.<br/>
    /// :meta private:
    /// </summary>
    public enum ReprocessBehavior
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReprocessBehaviorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReprocessBehavior value)
        {
            return value switch
            {
                ReprocessBehavior.Completed => "completed",
                ReprocessBehavior.Failed => "failed",
                ReprocessBehavior.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReprocessBehavior? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ReprocessBehavior.Completed,
                "failed" => ReprocessBehavior.Failed,
                "none" => ReprocessBehavior.None,
                _ => null,
            };
        }
    }
}