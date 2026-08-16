
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Health serializer for responses.
    /// </summary>
    public sealed partial class HealthInfoResponse
    {
        /// <summary>
        /// Base info serializer for responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadatabase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.BaseInfoResponse Metadatabase { get; set; }

        /// <summary>
        /// Scheduler info serializer for responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduler")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.SchedulerInfoResponse Scheduler { get; set; }

        /// <summary>
        /// Triggerer info serializer for responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.TriggererInfoResponse Triggerer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_processor")]
        public global::Loud.Technology.Airflow.Sdk.DagProcessorInfoResponse? DagProcessor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthInfoResponse" /> class.
        /// </summary>
        /// <param name="metadatabase">
        /// Base info serializer for responses.
        /// </param>
        /// <param name="scheduler">
        /// Scheduler info serializer for responses.
        /// </param>
        /// <param name="triggerer">
        /// Triggerer info serializer for responses.
        /// </param>
        /// <param name="dagProcessor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HealthInfoResponse(
            global::Loud.Technology.Airflow.Sdk.BaseInfoResponse metadatabase,
            global::Loud.Technology.Airflow.Sdk.SchedulerInfoResponse scheduler,
            global::Loud.Technology.Airflow.Sdk.TriggererInfoResponse triggerer,
            global::Loud.Technology.Airflow.Sdk.DagProcessorInfoResponse? dagProcessor)
        {
            this.Metadatabase = metadatabase ?? throw new global::System.ArgumentNullException(nameof(metadatabase));
            this.Scheduler = scheduler ?? throw new global::System.ArgumentNullException(nameof(scheduler));
            this.Triggerer = triggerer ?? throw new global::System.ArgumentNullException(nameof(triggerer));
            this.DagProcessor = dagProcessor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthInfoResponse" /> class.
        /// </summary>
        public HealthInfoResponse()
        {
        }

    }
}