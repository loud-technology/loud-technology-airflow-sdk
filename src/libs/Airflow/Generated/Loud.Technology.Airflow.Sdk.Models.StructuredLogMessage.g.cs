
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// An individual log message.
    /// </summary>
    public sealed partial class StructuredLogMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredLogMessage" /> class.
        /// </summary>
        /// <param name="event"></param>
        /// <param name="timestamp"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StructuredLogMessage(
            string @event,
            global::System.DateTime? timestamp)
        {
            this.Timestamp = timestamp;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredLogMessage" /> class.
        /// </summary>
        public StructuredLogMessage()
        {
        }

    }
}