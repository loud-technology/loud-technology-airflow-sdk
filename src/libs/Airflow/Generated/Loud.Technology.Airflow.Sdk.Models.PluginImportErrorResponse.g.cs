
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Plugin Import Error serializer for responses.
    /// </summary>
    public sealed partial class PluginImportErrorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginImportErrorResponse" /> class.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PluginImportErrorResponse(
            string source,
            string error)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginImportErrorResponse" /> class.
        /// </summary>
        public PluginImportErrorResponse()
        {
        }

    }
}