
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Serializer for individual bulk action responses.<br/>
    /// Represents the outcome of a single bulk operation (create, update, or delete).<br/>
    /// The response includes a list of successful keys and any errors encountered during the operation.<br/>
    /// This structure helps users understand which key actions succeeded and which failed.
    /// </summary>
    public sealed partial class BulkActionResponse
    {
        /// <summary>
        /// A list of unique id/key representing successful operations.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public global::System.Collections.Generic.IList<string>? Success { get; set; }

        /// <summary>
        /// A list of errors encountered during the operation, each containing details about the issue.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<object>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkActionResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// A list of unique id/key representing successful operations.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="errors">
        /// A list of errors encountered during the operation, each containing details about the issue.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkActionResponse(
            global::System.Collections.Generic.IList<string>? success,
            global::System.Collections.Generic.IList<object>? errors)
        {
            this.Success = success;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkActionResponse" /> class.
        /// </summary>
        public BulkActionResponse()
        {
        }

    }
}