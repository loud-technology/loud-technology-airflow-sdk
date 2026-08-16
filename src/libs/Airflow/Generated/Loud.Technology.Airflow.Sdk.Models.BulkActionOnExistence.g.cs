
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Bulk Action to be taken if the entity already exists or not.
    /// </summary>
    public enum BulkActionOnExistence
    {
        /// <summary>
        /// 
        /// </summary>
        Fail,
        /// <summary>
        /// 
        /// </summary>
        Overwrite,
        /// <summary>
        /// 
        /// </summary>
        Skip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BulkActionOnExistenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BulkActionOnExistence value)
        {
            return value switch
            {
                BulkActionOnExistence.Fail => "fail",
                BulkActionOnExistence.Overwrite => "overwrite",
                BulkActionOnExistence.Skip => "skip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BulkActionOnExistence? ToEnum(string value)
        {
            return value switch
            {
                "fail" => BulkActionOnExistence.Fail,
                "overwrite" => BulkActionOnExistence.Overwrite,
                "skip" => BulkActionOnExistence.Skip,
                _ => null,
            };
        }
    }
}