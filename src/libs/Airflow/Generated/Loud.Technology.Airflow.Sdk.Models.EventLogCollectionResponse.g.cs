
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Event Log Collection Response.
    /// </summary>
    public sealed partial class EventLogCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.EventLogResponse> EventLogs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalEntries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventLogCollectionResponse" /> class.
        /// </summary>
        /// <param name="eventLogs"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EventLogCollectionResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.EventLogResponse> eventLogs,
            int totalEntries)
        {
            this.EventLogs = eventLogs ?? throw new global::System.ArgumentNullException(nameof(eventLogs));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventLogCollectionResponse" /> class.
        /// </summary>
        public EventLogCollectionResponse()
        {
        }

    }
}