
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Default Value: nav
    /// </summary>
    public enum ReactAppResponseDestination
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
        Dashboard,
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
    public static class ReactAppResponseDestinationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactAppResponseDestination value)
        {
            return value switch
            {
                ReactAppResponseDestination.Dag => "dag",
                ReactAppResponseDestination.DagRun => "dag_run",
                ReactAppResponseDestination.Dashboard => "dashboard",
                ReactAppResponseDestination.Nav => "nav",
                ReactAppResponseDestination.Task => "task",
                ReactAppResponseDestination.TaskInstance => "task_instance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactAppResponseDestination? ToEnum(string value)
        {
            return value switch
            {
                "dag" => ReactAppResponseDestination.Dag,
                "dag_run" => ReactAppResponseDestination.DagRun,
                "dashboard" => ReactAppResponseDestination.Dashboard,
                "nav" => ReactAppResponseDestination.Nav,
                "task" => ReactAppResponseDestination.Task,
                "task_instance" => ReactAppResponseDestination.TaskInstance,
                _ => null,
            };
        }
    }
}