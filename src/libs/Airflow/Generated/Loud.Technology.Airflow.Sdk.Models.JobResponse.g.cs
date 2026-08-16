
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Job serializer for responses.
    /// </summary>
    public sealed partial class JobResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_id")]
        public string? DagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        public string? JobType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_heartbeat")]
        public global::System.DateTime? LatestHeartbeat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executor_class")]
        public string? ExecutorClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unixname")]
        public string? Unixname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_display_name")]
        public string? DagDisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dagId"></param>
        /// <param name="state"></param>
        /// <param name="jobType"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="latestHeartbeat"></param>
        /// <param name="executorClass"></param>
        /// <param name="hostname"></param>
        /// <param name="unixname"></param>
        /// <param name="dagDisplayName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobResponse(
            int id,
            string? dagId,
            string? state,
            string? jobType,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::System.DateTime? latestHeartbeat,
            string? executorClass,
            string? hostname,
            string? unixname,
            string? dagDisplayName)
        {
            this.Id = id;
            this.DagId = dagId;
            this.State = state;
            this.JobType = jobType;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.LatestHeartbeat = latestHeartbeat;
            this.ExecutorClass = executorClass;
            this.Hostname = hostname;
            this.Unixname = unixname;
            this.DagDisplayName = dagDisplayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobResponse" /> class.
        /// </summary>
        public JobResponse()
        {
        }

    }
}