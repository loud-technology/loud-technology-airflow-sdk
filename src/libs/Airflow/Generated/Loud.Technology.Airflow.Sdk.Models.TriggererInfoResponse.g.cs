
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Triggerer info serializer for responses.
    /// </summary>
    public sealed partial class TriggererInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_triggerer_heartbeat")]
        public string? LatestTriggererHeartbeat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggererInfoResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="latestTriggererHeartbeat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggererInfoResponse(
            string? status,
            string? latestTriggererHeartbeat)
        {
            this.Status = status;
            this.LatestTriggererHeartbeat = latestTriggererHeartbeat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggererInfoResponse" /> class.
        /// </summary>
        public TriggererInfoResponse()
        {
        }

    }
}