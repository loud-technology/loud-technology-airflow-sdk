
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Serializer for React App Plugin responses.
    /// </summary>
    public sealed partial class ReactAppResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_dark_mode")]
        public string? IconDarkMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_route")]
        public string? UrlRoute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bundle_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BundleUrl { get; set; }

        /// <summary>
        /// Default Value: nav
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.ReactAppResponseDestinationJsonConverter))]
        public global::Loud.Technology.Airflow.Sdk.ReactAppResponseDestination? Destination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactAppResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="bundleUrl"></param>
        /// <param name="icon"></param>
        /// <param name="iconDarkMode"></param>
        /// <param name="urlRoute"></param>
        /// <param name="category"></param>
        /// <param name="destination">
        /// Default Value: nav
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReactAppResponse(
            string name,
            string bundleUrl,
            string? icon,
            string? iconDarkMode,
            string? urlRoute,
            string? category,
            global::Loud.Technology.Airflow.Sdk.ReactAppResponseDestination? destination)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Icon = icon;
            this.IconDarkMode = iconDarkMode;
            this.UrlRoute = urlRoute;
            this.Category = category;
            this.BundleUrl = bundleUrl ?? throw new global::System.ArgumentNullException(nameof(bundleUrl));
            this.Destination = destination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactAppResponse" /> class.
        /// </summary>
        public ReactAppResponse()
        {
        }

    }
}