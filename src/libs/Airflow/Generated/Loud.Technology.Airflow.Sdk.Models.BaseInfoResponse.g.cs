
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Base info serializer for responses.
    /// </summary>
    public sealed partial class BaseInfoResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInfoResponse" /> class.
        /// </summary>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BaseInfoResponse(
            string? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseInfoResponse" /> class.
        /// </summary>
        public BaseInfoResponse()
        {
        }

    }
}