
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// All possible states that a DagRun can be in.<br/>
    /// These are "shared" with TaskInstanceState in some parts of the code,<br/>
    /// so please ensure that their values always match the ones with the<br/>
    /// same name in TaskInstanceState.
    /// </summary>
    public enum DagRunState
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
        Running,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DagRunStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DagRunState value)
        {
            return value switch
            {
                DagRunState.Failed => "failed",
                DagRunState.Queued => "queued",
                DagRunState.Running => "running",
                DagRunState.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DagRunState? ToEnum(string value)
        {
            return value switch
            {
                "failed" => DagRunState.Failed,
                "queued" => DagRunState.Queued,
                "running" => DagRunState.Running,
                "success" => DagRunState.Success,
                _ => null,
            };
        }
    }
}