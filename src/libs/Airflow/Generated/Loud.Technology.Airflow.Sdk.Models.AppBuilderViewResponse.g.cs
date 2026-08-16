
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Serializer for AppBuilder View responses.
    /// </summary>
    public sealed partial class AppBuilderViewResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        public string? View { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBuilderViewResponse" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="category"></param>
        /// <param name="view"></param>
        /// <param name="label"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppBuilderViewResponse(
            string? name,
            string? category,
            string? view,
            string? label)
        {
            this.Name = name;
            this.Category = category;
            this.View = view;
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppBuilderViewResponse" /> class.
        /// </summary>
        public AppBuilderViewResponse()
        {
        }

    }
}