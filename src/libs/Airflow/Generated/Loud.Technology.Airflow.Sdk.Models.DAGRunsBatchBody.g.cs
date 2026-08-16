
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// List DAG Runs body for batch endpoint.
    /// </summary>
    public sealed partial class DAGRunsBatchBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_offset")]
        public int? PageOffset { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_limit")]
        public int? PageLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_ids")]
        public global::System.Collections.Generic.IList<string>? DagIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("states")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagRunState>? States { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_after_gte")]
        public global::System.DateTime? RunAfterGte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_after_gt")]
        public global::System.DateTime? RunAfterGt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_after_lte")]
        public global::System.DateTime? RunAfterLte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_after_lt")]
        public global::System.DateTime? RunAfterLt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_date_gte")]
        public global::System.DateTime? LogicalDateGte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_date_gt")]
        public global::System.DateTime? LogicalDateGt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_date_lte")]
        public global::System.DateTime? LogicalDateLte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logical_date_lt")]
        public global::System.DateTime? LogicalDateLt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date_gte")]
        public global::System.DateTime? StartDateGte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date_gt")]
        public global::System.DateTime? StartDateGt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date_lte")]
        public global::System.DateTime? StartDateLte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date_lt")]
        public global::System.DateTime? StartDateLt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date_gte")]
        public global::System.DateTime? EndDateGte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date_gt")]
        public global::System.DateTime? EndDateGt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date_lte")]
        public global::System.DateTime? EndDateLte { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date_lt")]
        public global::System.DateTime? EndDateLt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGRunsBatchBody" /> class.
        /// </summary>
        /// <param name="orderBy"></param>
        /// <param name="pageOffset">
        /// Default Value: 0
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 100
        /// </param>
        /// <param name="dagIds"></param>
        /// <param name="states"></param>
        /// <param name="runAfterGte"></param>
        /// <param name="runAfterGt"></param>
        /// <param name="runAfterLte"></param>
        /// <param name="runAfterLt"></param>
        /// <param name="logicalDateGte"></param>
        /// <param name="logicalDateGt"></param>
        /// <param name="logicalDateLte"></param>
        /// <param name="logicalDateLt"></param>
        /// <param name="startDateGte"></param>
        /// <param name="startDateGt"></param>
        /// <param name="startDateLte"></param>
        /// <param name="startDateLt"></param>
        /// <param name="endDateGte"></param>
        /// <param name="endDateGt"></param>
        /// <param name="endDateLte"></param>
        /// <param name="endDateLt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DAGRunsBatchBody(
            string? orderBy,
            int? pageOffset,
            int? pageLimit,
            global::System.Collections.Generic.IList<string>? dagIds,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagRunState>? states,
            global::System.DateTime? runAfterGte,
            global::System.DateTime? runAfterGt,
            global::System.DateTime? runAfterLte,
            global::System.DateTime? runAfterLt,
            global::System.DateTime? logicalDateGte,
            global::System.DateTime? logicalDateGt,
            global::System.DateTime? logicalDateLte,
            global::System.DateTime? logicalDateLt,
            global::System.DateTime? startDateGte,
            global::System.DateTime? startDateGt,
            global::System.DateTime? startDateLte,
            global::System.DateTime? startDateLt,
            global::System.DateTime? endDateGte,
            global::System.DateTime? endDateGt,
            global::System.DateTime? endDateLte,
            global::System.DateTime? endDateLt)
        {
            this.OrderBy = orderBy;
            this.PageOffset = pageOffset;
            this.PageLimit = pageLimit;
            this.DagIds = dagIds;
            this.States = states;
            this.RunAfterGte = runAfterGte;
            this.RunAfterGt = runAfterGt;
            this.RunAfterLte = runAfterLte;
            this.RunAfterLt = runAfterLt;
            this.LogicalDateGte = logicalDateGte;
            this.LogicalDateGt = logicalDateGt;
            this.LogicalDateLte = logicalDateLte;
            this.LogicalDateLt = logicalDateLt;
            this.StartDateGte = startDateGte;
            this.StartDateGt = startDateGt;
            this.StartDateLte = startDateLte;
            this.StartDateLt = startDateLt;
            this.EndDateGte = endDateGte;
            this.EndDateGt = endDateGt;
            this.EndDateLte = endDateLte;
            this.EndDateLt = endDateLt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGRunsBatchBody" /> class.
        /// </summary>
        public DAGRunsBatchBody()
        {
        }

    }
}