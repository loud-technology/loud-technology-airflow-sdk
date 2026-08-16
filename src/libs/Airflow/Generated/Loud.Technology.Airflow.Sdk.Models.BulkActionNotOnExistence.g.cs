
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Bulk Action to be taken if the entity does not exist.
    /// </summary>
    public enum BulkActionNotOnExistence
    {
        /// <summary>
        /// 
        /// </summary>
        Fail,
        /// <summary>
        /// 
        /// </summary>
        Skip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkActionNotOnExistenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkActionNotOnExistence value)
        {
            return value switch
            {
                BulkActionNotOnExistence.Fail => "fail",
                BulkActionNotOnExistence.Skip => "skip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkActionNotOnExistence? ToEnum(string value)
        {
            return value switch
            {
                "fail" => BulkActionNotOnExistence.Fail,
                "skip" => BulkActionNotOnExistence.Skip,
                _ => null,
            };
        }
    }
}