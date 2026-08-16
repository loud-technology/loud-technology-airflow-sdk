
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// DAG Run serializer for clear endpoint body.
    /// </summary>
    public sealed partial class DAGRunClearBody
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dry_run")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("only_failed")]
        public bool? OnlyFailed { get; set; }

        /// <summary>
        /// (Experimental) Run on the latest bundle version of the Dag after clearing the Dag Run.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_on_latest_version")]
        public bool? RunOnLatestVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGRunClearBody" /> class.
        /// </summary>
        /// <param name="dryRun">
        /// Default Value: true
        /// </param>
        /// <param name="onlyFailed">
        /// Default Value: false
        /// </param>
        /// <param name="runOnLatestVersion">
        /// (Experimental) Run on the latest bundle version of the Dag after clearing the Dag Run.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DAGRunClearBody(
            bool? dryRun,
            bool? onlyFailed,
            bool? runOnLatestVersion)
        {
            this.DryRun = dryRun;
            this.OnlyFailed = onlyFailed;
            this.RunOnLatestVersion = runOnLatestVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGRunClearBody" /> class.
        /// </summary>
        public DAGRunClearBody()
        {
        }

    }
}