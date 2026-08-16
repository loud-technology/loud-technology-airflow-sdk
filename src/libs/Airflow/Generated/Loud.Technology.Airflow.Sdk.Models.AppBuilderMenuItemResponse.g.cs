
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Serializer for AppBuilder Menu Item responses.
    /// </summary>
    public sealed partial class AppBuilderMenuItemResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Href { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBuilderMenuItemResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="href"></param>
        /// <param name="category"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppBuilderMenuItemResponse(
            string name,
            string href,
            string? category)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Href = href ?? throw new global::System.ArgumentNullException(nameof(href));
            this.Category = category;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBuilderMenuItemResponse" /> class.
        /// </summary>
        public AppBuilderMenuItemResponse()
        {
        }

    }
}