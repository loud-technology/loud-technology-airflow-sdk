
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Serializer for Plugin FastAPI App responses.
    /// </summary>
    public sealed partial class FastAPIAppResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UrlPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FastAPIAppResponse" /> class.
        /// </summary>
        /// <param name="app"></param>
        /// <param name="urlPrefix"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FastAPIAppResponse(
            string app,
            string urlPrefix,
            string name)
        {
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.UrlPrefix = urlPrefix ?? throw new global::System.ArgumentNullException(nameof(urlPrefix));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FastAPIAppResponse" /> class.
        /// </summary>
        public FastAPIAppResponse()
        {
        }

    }
}