
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Enum for DAG warning types.<br/>
    /// This is the set of allowable values for the ``warning_type`` field<br/>
    /// in the DagWarning model.
    /// </summary>
    public enum DagWarningType
    {
        /// <summary>
        /// 
        /// </summary>
        AssetConflict,
        /// <summary>
        /// 
        /// </summary>
        NonExistentPool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DagWarningTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DagWarningType value)
        {
            return value switch
            {
                DagWarningType.AssetConflict => "asset conflict",
                DagWarningType.NonExistentPool => "non-existent pool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DagWarningType? ToEnum(string value)
        {
            return value switch
            {
                "asset conflict" => DagWarningType.AssetConflict,
                "non-existent pool" => DagWarningType.NonExistentPool,
                _ => null,
            };
        }
    }
}