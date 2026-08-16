
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// A list of `task_id` or [`task_id`, `map_index`]. If only the `task_id` is provided for a mapped task, all of its map indices will be targeted.
    /// </summary>
    public sealed partial class ClearTaskInstancesBodyTaskIds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}