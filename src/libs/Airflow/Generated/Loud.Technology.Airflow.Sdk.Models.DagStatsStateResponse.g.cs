
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// DagStatsState serializer for responses.
    /// </summary>
    public sealed partial class DagStatsStateResponse
    {
        /// <summary>
        /// All possible states that a DagRun can be in.<br/>
        /// These are "shared" with TaskInstanceState in some parts of the code,<br/>
        /// so please ensure that their values always match the ones with the<br/>
        /// same name in TaskInstanceState.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagRunStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.DagRunState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DagStatsStateResponse" /> class.
        /// </summary>
        /// <param name="state">
        /// All possible states that a DagRun can be in.<br/>
        /// These are "shared" with TaskInstanceState in some parts of the code,<br/>
        /// so please ensure that their values always match the ones with the<br/>
        /// same name in TaskInstanceState.
        /// </param>
        /// <param name="count"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DagStatsStateResponse(
            global::Loud.Technology.Airflow.Sdk.DagRunState state,
            int count)
        {
            this.State = state;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DagStatsStateResponse" /> class.
        /// </summary>
        public DagStatsStateResponse()
        {
        }

    }
}