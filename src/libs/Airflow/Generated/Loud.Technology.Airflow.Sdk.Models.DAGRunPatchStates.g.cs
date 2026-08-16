
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Enum for DAG Run states when updating a DAG Run.
    /// </summary>
    public enum DAGRunPatchStates
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DAGRunPatchStatesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DAGRunPatchStates value)
        {
            return value switch
            {
                DAGRunPatchStates.Failed => "failed",
                DAGRunPatchStates.Queued => "queued",
                DAGRunPatchStates.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DAGRunPatchStates? ToEnum(string value)
        {
            return value switch
            {
                "failed" => DAGRunPatchStates.Failed,
                "queued" => DAGRunPatchStates.Queued,
                "success" => DAGRunPatchStates.Success,
                _ => null,
            };
        }
    }
}