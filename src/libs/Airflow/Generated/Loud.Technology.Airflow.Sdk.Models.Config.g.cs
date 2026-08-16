
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// List of config sections with their options.
    /// </summary>
    public sealed partial class Config
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ConfigSection> Sections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        /// <param name="sections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Config(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ConfigSection> sections)
        {
            this.Sections = sections ?? throw new global::System.ArgumentNullException(nameof(sections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Config" /> class.
        /// </summary>
        public Config()
        {
        }

    }
}