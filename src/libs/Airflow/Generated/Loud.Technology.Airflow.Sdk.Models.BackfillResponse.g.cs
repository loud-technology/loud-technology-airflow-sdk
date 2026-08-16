
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Base serializer for Backfill.
    /// </summary>
    public sealed partial class BackfillResponse
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FromDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ToDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_run_conf")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object DagRunConf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_paused")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPaused { get; set; }

        /// <summary>
        /// Internal enum for setting reprocess behavior in a backfill.<br/>
        /// :meta private:
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reprocess_behavior")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.ReprocessBehaviorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.ReprocessBehavior ReprocessBehavior { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_active_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxActiveRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagDisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackfillResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dagId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="dagRunConf"></param>
        /// <param name="isPaused"></param>
        /// <param name="reprocessBehavior">
        /// Internal enum for setting reprocess behavior in a backfill.<br/>
        /// :meta private:
        /// </param>
        /// <param name="maxActiveRuns"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="dagDisplayName"></param>
        /// <param name="completedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackfillResponse(
            int id,
            string dagId,
            global::System.DateTime fromDate,
            global::System.DateTime toDate,
            object dagRunConf,
            bool isPaused,
            global::Loud.Technology.Airflow.Sdk.ReprocessBehavior reprocessBehavior,
            int maxActiveRuns,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string dagDisplayName,
            global::System.DateTime? completedAt)
        {
            this.Id = id;
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.DagRunConf = dagRunConf ?? throw new global::System.ArgumentNullException(nameof(dagRunConf));
            this.IsPaused = isPaused;
            this.ReprocessBehavior = reprocessBehavior;
            this.MaxActiveRuns = maxActiveRuns;
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.UpdatedAt = updatedAt;
            this.DagDisplayName = dagDisplayName ?? throw new global::System.ArgumentNullException(nameof(dagDisplayName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackfillResponse" /> class.
        /// </summary>
        public BackfillResponse()
        {
        }

    }
}