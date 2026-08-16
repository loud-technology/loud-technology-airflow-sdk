
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Task scheduling dependencies collection serializer for responses.
    /// </summary>
    public sealed partial class TaskDependencyCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskDependencyResponse> Dependencies { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDependencyCollectionResponse" /> class.
        /// </summary>
        /// <param name="dependencies"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskDependencyCollectionResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskDependencyResponse> dependencies)
        {
            this.Dependencies = dependencies ?? throw new global::System.ArgumentNullException(nameof(dependencies));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDependencyCollectionResponse" /> class.
        /// </summary>
        public TaskDependencyCollectionResponse()
        {
        }

    }
}