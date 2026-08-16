
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// DagProcessor info serializer for responses.
    /// </summary>
    public sealed partial class DagProcessorInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_dag_processor_heartbeat")]
        public string? LatestDagProcessorHeartbeat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DagProcessorInfoResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="latestDagProcessorHeartbeat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DagProcessorInfoResponse(
            string? status,
            string? latestDagProcessorHeartbeat)
        {
            this.Status = status;
            this.LatestDagProcessorHeartbeat = latestDagProcessorHeartbeat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DagProcessorInfoResponse" /> class.
        /// </summary>
        public DagProcessorInfoResponse()
        {
        }

    }
}