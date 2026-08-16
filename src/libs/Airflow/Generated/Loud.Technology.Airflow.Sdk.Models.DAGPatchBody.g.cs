
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Dag Serializer for updatable bodies.
    /// </summary>
    public sealed partial class DAGPatchBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_paused")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPaused { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGPatchBody" /> class.
        /// </summary>
        /// <param name="isPaused"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DAGPatchBody(
            bool isPaused)
        {
            this.IsPaused = isPaused;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGPatchBody" /> class.
        /// </summary>
        public DAGPatchBody()
        {
        }

    }
}