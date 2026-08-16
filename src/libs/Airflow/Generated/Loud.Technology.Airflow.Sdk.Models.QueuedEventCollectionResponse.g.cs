
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Queued Event Collection serializer for responses.
    /// </summary>
    public sealed partial class QueuedEventCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued_events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.QueuedEventResponse> QueuedEvents { get; set; }

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
        /// Initializes a new instance of the <see cref="QueuedEventCollectionResponse" /> class.
        /// </summary>
        /// <param name="queuedEvents"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueuedEventCollectionResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.QueuedEventResponse> queuedEvents,
            int totalEntries)
        {
            this.QueuedEvents = queuedEvents ?? throw new global::System.ArgumentNullException(nameof(queuedEvents));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueuedEventCollectionResponse" /> class.
        /// </summary>
        public QueuedEventCollectionResponse()
        {
        }

    }
}