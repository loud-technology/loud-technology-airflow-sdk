
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// All possible states that a Task Instance can be in.<br/>
    /// Note that None is also allowed, so always use this in a type hint with Optional.
    /// </summary>
    public enum TaskInstanceState
    {
        /// <summary>
        /// 
        /// </summary>
        Deferred,
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
        Removed,
        /// <summary>
        /// 
        /// </summary>
        Restarting,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        UpForReschedule,
        /// <summary>
        /// 
        /// </summary>
        UpForRetry,
        /// <summary>
        /// 
        /// </summary>
        UpstreamFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TaskInstanceStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TaskInstanceState value)
        {
            return value switch
            {
                TaskInstanceState.Deferred => "deferred",
                TaskInstanceState.Failed => "failed",
                TaskInstanceState.Queued => "queued",
                TaskInstanceState.Removed => "removed",
                TaskInstanceState.Restarting => "restarting",
                TaskInstanceState.Running => "running",
                TaskInstanceState.Scheduled => "scheduled",
                TaskInstanceState.Skipped => "skipped",
                TaskInstanceState.Success => "success",
                TaskInstanceState.UpForReschedule => "up_for_reschedule",
                TaskInstanceState.UpForRetry => "up_for_retry",
                TaskInstanceState.UpstreamFailed => "upstream_failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TaskInstanceState? ToEnum(string value)
        {
            return value switch
            {
                "deferred" => TaskInstanceState.Deferred,
                "failed" => TaskInstanceState.Failed,
                "queued" => TaskInstanceState.Queued,
                "removed" => TaskInstanceState.Removed,
                "restarting" => TaskInstanceState.Restarting,
                "running" => TaskInstanceState.Running,
                "scheduled" => TaskInstanceState.Scheduled,
                "skipped" => TaskInstanceState.Skipped,
                "success" => TaskInstanceState.Success,
                "up_for_reschedule" => TaskInstanceState.UpForReschedule,
                "up_for_retry" => TaskInstanceState.UpForRetry,
                "upstream_failed" => TaskInstanceState.UpstreamFailed,
                _ => null,
            };
        }
    }
}