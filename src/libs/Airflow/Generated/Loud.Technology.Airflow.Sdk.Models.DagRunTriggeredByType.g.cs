
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Class with TriggeredBy types for DagRun.
    /// </summary>
    public enum DagRunTriggeredByType
    {
        /// <summary>
        /// 
        /// </summary>
        Asset,
        /// <summary>
        /// 
        /// </summary>
        Backfill,
        /// <summary>
        /// 
        /// </summary>
        Cli,
        /// <summary>
        /// 
        /// </summary>
        Operator,
        /// <summary>
        /// 
        /// </summary>
        RestApi,
        /// <summary>
        /// 
        /// </summary>
        Test,
        /// <summary>
        /// 
        /// </summary>
        Timetable,
        /// <summary>
        /// 
        /// </summary>
        Ui,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DagRunTriggeredByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DagRunTriggeredByType value)
        {
            return value switch
            {
                DagRunTriggeredByType.Asset => "asset",
                DagRunTriggeredByType.Backfill => "backfill",
                DagRunTriggeredByType.Cli => "cli",
                DagRunTriggeredByType.Operator => "operator",
                DagRunTriggeredByType.RestApi => "rest_api",
                DagRunTriggeredByType.Test => "test",
                DagRunTriggeredByType.Timetable => "timetable",
                DagRunTriggeredByType.Ui => "ui",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DagRunTriggeredByType? ToEnum(string value)
        {
            return value switch
            {
                "asset" => DagRunTriggeredByType.Asset,
                "backfill" => DagRunTriggeredByType.Backfill,
                "cli" => DagRunTriggeredByType.Cli,
                "operator" => DagRunTriggeredByType.Operator,
                "rest_api" => DagRunTriggeredByType.RestApi,
                "test" => DagRunTriggeredByType.Test,
                "timetable" => DagRunTriggeredByType.Timetable,
                "ui" => DagRunTriggeredByType.Ui,
                _ => null,
            };
        }
    }
}