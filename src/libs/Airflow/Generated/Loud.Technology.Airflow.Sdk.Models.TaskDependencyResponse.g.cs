
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Task Dependency serializer for responses.
    /// </summary>
    public sealed partial class TaskDependencyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDependencyResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskDependencyResponse(
            string name,
            string reason)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDependencyResponse" /> class.
        /// </summary>
        public TaskDependencyResponse()
        {
        }

    }
}