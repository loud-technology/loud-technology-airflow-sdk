
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// HTTPException Model used for error response.
    /// </summary>
    public sealed partial class HTTPExceptionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<string, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Loud.Technology.Airflow.Sdk.AnyOf<string, object> Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPExceptionResponse" /> class.
        /// </summary>
        /// <param name="detail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HTTPExceptionResponse(
            global::Loud.Technology.Airflow.Sdk.AnyOf<string, object> detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPExceptionResponse" /> class.
        /// </summary>
        public HTTPExceptionResponse()
        {
        }

    }
}