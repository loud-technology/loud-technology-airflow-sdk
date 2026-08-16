
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Version information serializer for responses.
    /// </summary>
    public sealed partial class VersionInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git_version")]
        public string? GitVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInfo" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="gitVersion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VersionInfo(
            string version,
            string? gitVersion)
        {
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.GitVersion = gitVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInfo" /> class.
        /// </summary>
        public VersionInfo()
        {
        }

    }
}