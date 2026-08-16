
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Provider serializer for responses.
    /// </summary>
    public sealed partial class ProviderResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("package_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PackageName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentation_url")]
        public string? DocumentationUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderResponse" /> class.
        /// </summary>
        /// <param name="packageName"></param>
        /// <param name="description"></param>
        /// <param name="version"></param>
        /// <param name="documentationUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderResponse(
            string packageName,
            string description,
            string version,
            string? documentationUrl)
        {
            this.PackageName = packageName ?? throw new global::System.ArgumentNullException(nameof(packageName));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.DocumentationUrl = documentationUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderResponse" /> class.
        /// </summary>
        public ProviderResponse()
        {
        }

    }
}