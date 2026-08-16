
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Class with DagRun types.
    /// </summary>
    public enum DagRunType
    {
        /// <summary>
        /// 
        /// </summary>
        AssetTriggered,
        /// <summary>
        /// 
        /// </summary>
        Backfill,
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DagRunTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DagRunType value)
        {
            return value switch
            {
                DagRunType.AssetTriggered => "asset_triggered",
                DagRunType.Backfill => "backfill",
                DagRunType.Manual => "manual",
                DagRunType.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DagRunType? ToEnum(string value)
        {
            return value switch
            {
                "asset_triggered" => DagRunType.AssetTriggered,
                "backfill" => DagRunType.Backfill,
                "manual" => DagRunType.Manual,
                "scheduled" => DagRunType.Scheduled,
                _ => null,
            };
        }
    }
}