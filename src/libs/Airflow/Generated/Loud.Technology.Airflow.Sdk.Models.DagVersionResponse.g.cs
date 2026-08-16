
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Dag Version serializer for responses.
    /// </summary>
    public sealed partial class DagVersionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_name")]
        public string? BundleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_version")]
        public string? BundleVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dag_display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DagDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_url")]
        public string? BundleUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DagVersionResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="versionNumber"></param>
        /// <param name="dagId"></param>
        /// <param name="createdAt"></param>
        /// <param name="dagDisplayName"></param>
        /// <param name="bundleName"></param>
        /// <param name="bundleVersion"></param>
        /// <param name="bundleUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DagVersionResponse(
            global::System.Guid id,
            int versionNumber,
            string dagId,
            global::System.DateTime createdAt,
            string dagDisplayName,
            string? bundleName,
            string? bundleVersion,
            string? bundleUrl)
        {
            this.Id = id;
            this.VersionNumber = versionNumber;
            this.DagId = dagId ?? throw new global::System.ArgumentNullException(nameof(dagId));
            this.BundleName = bundleName;
            this.BundleVersion = bundleVersion;
            this.CreatedAt = createdAt;
            this.DagDisplayName = dagDisplayName ?? throw new global::System.ArgumentNullException(nameof(dagDisplayName));
            this.BundleUrl = bundleUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DagVersionResponse" /> class.
        /// </summary>
        public DagVersionResponse()
        {
        }

    }
}