
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Trigger serializer for responses.
    /// </summary>
    public sealed partial class TriggerResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("classpath")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Classpath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kwargs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kwargs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggerer_id")]
        public int? TriggererId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="classpath"></param>
        /// <param name="kwargs"></param>
        /// <param name="createdDate"></param>
        /// <param name="triggererId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerResponse(
            int id,
            string classpath,
            string kwargs,
            global::System.DateTime createdDate,
            int? triggererId)
        {
            this.Id = id;
            this.Classpath = classpath ?? throw new global::System.ArgumentNullException(nameof(classpath));
            this.Kwargs = kwargs ?? throw new global::System.ArgumentNullException(nameof(kwargs));
            this.CreatedDate = createdDate;
            this.TriggererId = triggererId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerResponse" /> class.
        /// </summary>
        public TriggerResponse()
        {
        }

    }
}