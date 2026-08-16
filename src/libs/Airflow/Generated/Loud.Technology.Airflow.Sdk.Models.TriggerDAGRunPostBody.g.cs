
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Trigger DAG Run Serializer for POST body.
    /// </summary>
    public sealed partial class TriggerDAGRunPostBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_run_id")]
        public string? DagRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_interval_start")]
        public global::System.DateTime? DataIntervalStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_interval_end")]
        public global::System.DateTime? DataIntervalEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_date")]
        public global::System.DateTime? LogicalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_after")]
        public global::System.DateTime? RunAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conf")]
        public object? Conf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerDAGRunPostBody" /> class.
        /// </summary>
        /// <param name="dagRunId"></param>
        /// <param name="dataIntervalStart"></param>
        /// <param name="dataIntervalEnd"></param>
        /// <param name="logicalDate"></param>
        /// <param name="runAfter"></param>
        /// <param name="conf"></param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerDAGRunPostBody(
            string? dagRunId,
            global::System.DateTime? dataIntervalStart,
            global::System.DateTime? dataIntervalEnd,
            global::System.DateTime? logicalDate,
            global::System.DateTime? runAfter,
            object? conf,
            string? note)
        {
            this.DagRunId = dagRunId;
            this.DataIntervalStart = dataIntervalStart;
            this.DataIntervalEnd = dataIntervalEnd;
            this.LogicalDate = logicalDate;
            this.RunAfter = runAfter;
            this.Conf = conf;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerDAGRunPostBody" /> class.
        /// </summary>
        public TriggerDAGRunPostBody()
        {
        }

    }
}