
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Specific serializer for DAG Details responses.
    /// </summary>
    public sealed partial class DAGDetailsResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("is_paused")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPaused { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_stale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsStale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_parsed_time")]
        public global::System.DateTime? LastParsedTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_parse_duration")]
        public double? LastParseDuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_expired")]
        public global::System.DateTime? LastExpired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_name")]
        public string? BundleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_version")]
        public string? BundleVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relative_fileloc")]
        public string? RelativeFileloc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileloc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fileloc { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timetable_summary")]
        public string? TimetableSummary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timetable_description")]
        public string? TimetableDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagTagResponse> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_active_tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxActiveTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_active_runs")]
        public int? MaxActiveRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_consecutive_failed_dag_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxConsecutiveFailedDagRuns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_task_concurrency_limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasTaskConcurrencyLimits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_import_errors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasImportErrors { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_dagrun_logical_date")]
        public global::System.DateTime? NextDagrunLogicalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_dagrun_data_interval_start")]
        public global::System.DateTime? NextDagrunDataIntervalStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_dagrun_data_interval_end")]
        public global::System.DateTime? NextDagrunDataIntervalEnd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_dagrun_run_after")]
        public global::System.DateTime? NextDagrunRunAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owners")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Owners { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catchup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Catchup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_run_timeout")]
        public string? DagRunTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_expression")]
        public object? AssetExpression { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("doc_md")]
        public string? DocMd { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("is_paused_upon_creation")]
        public bool? IsPausedUponCreation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        public object? Params { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_template_as_native_obj")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RenderTemplateAsNativeObj { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_search_path")]
        public global::System.Collections.Generic.IList<string>? TemplateSearchPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_parsed")]
        public global::System.DateTime? LastParsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_args")]
        public object? DefaultArgs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_links")]
        public global::System.Collections.Generic.Dictionary<string, string>? OwnerLinks { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_favorite")]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// Return file token.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_token")]
        public string FileToken { get; set; } = default!;

        /// <summary>
        /// Return max_active_tasks as concurrency.<br/>
        /// Deprecated: Use max_active_tasks instead.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("concurrency")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int Concurrency { get; set; } = default!;

        /// <summary>
        /// Return the latest DagVersion.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_dag_version")]
        public global::Loud.Technology.Airflow.Sdk.DagVersionResponse? LatestDagVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGDetailsResponse" /> class.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagDisplayName"></param>
        /// <param name="isPaused"></param>
        /// <param name="isStale"></param>
        /// <param name="fileloc"></param>
        /// <param name="tags"></param>
        /// <param name="maxActiveTasks"></param>
        /// <param name="maxConsecutiveFailedDagRuns"></param>
        /// <param name="hasTaskConcurrencyLimits"></param>
        /// <param name="hasImportErrors"></param>
        /// <param name="owners"></param>
        /// <param name="catchup"></param>
        /// <param name="renderTemplateAsNativeObj"></param>
        /// <param name="lastParsedTime"></param>
        /// <param name="lastParseDuration"></param>
        /// <param name="lastExpired"></param>
        /// <param name="bundleName"></param>
        /// <param name="bundleVersion"></param>
        /// <param name="relativeFileloc"></param>
        /// <param name="description"></param>
        /// <param name="timetableSummary"></param>
        /// <param name="timetableDescription"></param>
        /// <param name="maxActiveRuns"></param>
        /// <param name="nextDagrunLogicalDate"></param>
        /// <param name="nextDagrunDataIntervalStart"></param>
        /// <param name="nextDagrunDataIntervalEnd"></param>
        /// <param name="nextDagrunRunAfter"></param>
        /// <param name="dagRunTimeout"></param>
        /// <param name="assetExpression"></param>
        /// <param name="docMd"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="isPausedUponCreation"></param>
        /// <param name="params"></param>
        /// <param name="templateSearchPath"></param>
        /// <param name="timezone"></param>
        /// <param name="lastParsed"></param>
        /// <param name="defaultArgs"></param>
        /// <param name="ownerLinks"></param>
        /// <param name="isFavorite">
        /// Default Value: false
        /// </param>
        /// <param name="latestDagVersion">
        /// Return the latest DagVersion.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="fileToken">
        /// Return file token.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DAGDetailsResponse(
            string dagId,
            string dagDisplayName,
            bool isPaused,
            bool isStale,
            string fileloc,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagTagResponse> tags,
            int maxActiveTasks,
            int maxConsecutiveFailedDagRuns,
            bool hasTaskConcurrencyLimits,
            bool hasImportErrors,
            global::System.Collections.Generic.IList<string> owners,
            bool catchup,
            bool renderTemplateAsNativeObj,
            global::System.DateTime? lastParsedTime,
            double? lastParseDuration,
            global::System.DateTime? lastExpired,
            string? bundleName,
            string? bundleVersion,
            string? relativeFileloc,
            string? description,
            string? timetableSummary,
            string? timetableDescription,
            int? maxActiveRuns,
            global::System.DateTime? nextDagrunLogicalDate,
            global::System.DateTime? nextDagrunDataIntervalStart,
            global::System.DateTime? nextDagrunDataIntervalEnd,
            global::System.DateTime? nextDagrunRunAfter,
            string? dagRunTimeout,
            object? assetExpression,
            string? docMd,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            bool? isPausedUponCreation,
            object? @params,
            global::System.Collections.Generic.IList<string>? templateSearchPath,
            string? timezone,
            global::System.DateTime? lastParsed,
            object? defaultArgs,
            global::System.Collections.Generic.Dictionary<string, string>? ownerLinks,
            bool? isFavorite,
            global::Loud.Technology.Airflow.Sdk.DagVersionResponse? latestDagVersion,
            string fileToken = default!)
        {
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.DagDisplayName = dagDisplayName ?? throw new global::System.ArgumentNullException(nameof(dagDisplayName));
            this.IsPaused = isPaused;
            this.IsStale = isStale;
            this.LastParsedTime = lastParsedTime;
            this.LastParseDuration = lastParseDuration;
            this.LastExpired = lastExpired;
            this.BundleName = bundleName;
            this.BundleVersion = bundleVersion;
            this.RelativeFileloc = relativeFileloc;
            this.Fileloc = fileloc ?? throw new global::System.ArgumentNullException(nameof(fileloc));
            this.Description = description;
            this.TimetableSummary = timetableSummary;
            this.TimetableDescription = timetableDescription;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.MaxActiveTasks = maxActiveTasks;
            this.MaxActiveRuns = maxActiveRuns;
            this.MaxConsecutiveFailedDagRuns = maxConsecutiveFailedDagRuns;
            this.HasTaskConcurrencyLimits = hasTaskConcurrencyLimits;
            this.HasImportErrors = hasImportErrors;
            this.NextDagrunLogicalDate = nextDagrunLogicalDate;
            this.NextDagrunDataIntervalStart = nextDagrunDataIntervalStart;
            this.NextDagrunDataIntervalEnd = nextDagrunDataIntervalEnd;
            this.NextDagrunRunAfter = nextDagrunRunAfter;
            this.Owners = owners ?? throw new global::System.ArgumentNullException(nameof(owners));
            this.Catchup = catchup;
            this.DagRunTimeout = dagRunTimeout;
            this.AssetExpression = assetExpression;
            this.DocMd = docMd;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.IsPausedUponCreation = isPausedUponCreation;
            this.Params = @params;
            this.RenderTemplateAsNativeObj = renderTemplateAsNativeObj;
            this.TemplateSearchPath = templateSearchPath;
            this.Timezone = timezone;
            this.LastParsed = lastParsed;
            this.DefaultArgs = defaultArgs;
            this.OwnerLinks = ownerLinks;
            this.IsFavorite = isFavorite;
            this.FileToken = fileToken;
            this.LatestDagVersion = latestDagVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DAGDetailsResponse" /> class.
        /// </summary>
        public DAGDetailsResponse()
        {
        }

    }
}