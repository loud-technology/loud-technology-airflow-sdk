
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Config Section Schema.
    /// </summary>
    public sealed partial class ConfigSection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ConfigOption> Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigSection" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigSection(
            string name,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ConfigOption> options)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigSection" /> class.
        /// </summary>
        public ConfigSection()
        {
        }

    }
}