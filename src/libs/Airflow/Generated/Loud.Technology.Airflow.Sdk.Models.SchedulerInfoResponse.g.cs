
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Scheduler info serializer for responses.
    /// </summary>
    public sealed partial class SchedulerInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_scheduler_heartbeat")]
        public string? LatestSchedulerHeartbeat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerInfoResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="latestSchedulerHeartbeat"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SchedulerInfoResponse(
            string? status,
            string? latestSchedulerHeartbeat)
        {
            this.Status = status;
            this.LatestSchedulerHeartbeat = latestSchedulerHeartbeat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulerInfoResponse" /> class.
        /// </summary>
        public SchedulerInfoResponse()
        {
        }

    }
}