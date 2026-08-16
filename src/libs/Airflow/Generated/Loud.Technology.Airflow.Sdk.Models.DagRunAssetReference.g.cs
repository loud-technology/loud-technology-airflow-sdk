
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// DAGRun serializer for asset responses.
    /// </summary>
    public sealed partial class DagRunAssetReference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_date")]
        public global::System.DateTime? LogicalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DagRunAssetReference" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="dagId"></param>
        /// <param name="startDate"></param>
        /// <param name="state"></param>
        /// <param name="logicalDate"></param>
        /// <param name="endDate"></param>
        /// <param name="dataIntervalStart"></param>
        /// <param name="dataIntervalEnd"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DagRunAssetReference(
            string runId,
            string dagId,
            global::System.DateTime startDate,
            string state,
            global::System.DateTime? logicalDate,
            global::System.DateTime? endDate,
            global::System.DateTime? dataIntervalStart,
            global::System.DateTime? dataIntervalEnd)
        {
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.LogicalDate = logicalDate;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.DataIntervalStart = dataIntervalStart;
            this.DataIntervalEnd = dataIntervalEnd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DagRunAssetReference" /> class.
        /// </summary>
        public DagRunAssetReference()
        {
        }

    }
}