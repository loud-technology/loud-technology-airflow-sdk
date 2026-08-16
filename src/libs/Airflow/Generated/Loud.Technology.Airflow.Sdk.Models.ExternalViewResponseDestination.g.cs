
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Default Value: nav
    /// </summary>
    public enum ExternalViewResponseDestination
    {
        /// <summary>
        /// 
        /// </summary>
        Dag,
        /// <summary>
        /// 
        /// </summary>
        DagRun,
        /// <summary>
        /// 
        /// </summary>
        Nav,
        /// <summary>
        /// 
        /// </summary>
        Task,
        /// <summary>
        /// 
        /// </summary>
        TaskInstance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalViewResponseDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalViewResponseDestination value)
        {
            return value switch
            {
                ExternalViewResponseDestination.Dag => "dag",
                ExternalViewResponseDestination.DagRun => "dag_run",
                ExternalViewResponseDestination.Nav => "nav",
                ExternalViewResponseDestination.Task => "task",
                ExternalViewResponseDestination.TaskInstance => "task_instance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalViewResponseDestination? ToEnum(string value)
        {
            return value switch
            {
                "dag" => ExternalViewResponseDestination.Dag,
                "dag_run" => ExternalViewResponseDestination.DagRun,
                "nav" => ExternalViewResponseDestination.Nav,
                "task" => ExternalViewResponseDestination.Task,
                "task_instance" => ExternalViewResponseDestination.TaskInstance,
                _ => null,
            };
        }
    }
}