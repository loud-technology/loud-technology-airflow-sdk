
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// DAG Stats serializer for responses.
    /// </summary>
    public sealed partial class DagStatsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagStatsStateResponse> Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DagStatsResponse" /> class.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagDisplayName"></param>
        /// <param name="stats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DagStatsResponse(
            string dagId,
            string dagDisplayName,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagStatsStateResponse> stats)
        {
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.DagDisplayName = dagDisplayName ?? throw new global::System.ArgumentNullException(nameof(dagDisplayName));
            this.Stats = stats ?? throw new global::System.ArgumentNullException(nameof(stats));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DagStatsResponse" /> class.
        /// </summary>
        public DagStatsResponse()
        {
        }

    }
}