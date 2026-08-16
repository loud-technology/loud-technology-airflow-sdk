
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Request body for Clear Task Instances endpoint.
    /// </summary>
    public sealed partial class PatchTaskInstanceBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_state")]
        public global::Loud.Technology.Airflow.Sdk.TaskInstanceState? NewState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_upstream")]
        public bool? IncludeUpstream { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_downstream")]
        public bool? IncludeDownstream { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_future")]
        public bool? IncludeFuture { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_past")]
        public bool? IncludePast { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTaskInstanceBody" /> class.
        /// </summary>
        /// <param name="newState"></param>
        /// <param name="note"></param>
        /// <param name="includeUpstream">
        /// Default Value: false
        /// </param>
        /// <param name="includeDownstream">
        /// Default Value: false
        /// </param>
        /// <param name="includeFuture">
        /// Default Value: false
        /// </param>
        /// <param name="includePast">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTaskInstanceBody(
            global::Loud.Technology.Airflow.Sdk.TaskInstanceState? newState,
            string? note,
            bool? includeUpstream,
            bool? includeDownstream,
            bool? includeFuture,
            bool? includePast)
        {
            this.NewState = newState;
            this.Note = note;
            this.IncludeUpstream = includeUpstream;
            this.IncludeDownstream = includeDownstream;
            this.IncludeFuture = includeFuture;
            this.IncludePast = includePast;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTaskInstanceBody" /> class.
        /// </summary>
        public PatchTaskInstanceBody()
        {
        }

    }
}