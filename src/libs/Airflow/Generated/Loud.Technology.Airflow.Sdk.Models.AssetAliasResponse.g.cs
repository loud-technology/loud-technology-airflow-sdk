
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Asset alias serializer for responses.
    /// </summary>
    public sealed partial class AssetAliasResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Group { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetAliasResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="group"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetAliasResponse(
            int id,
            string name,
            string group)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetAliasResponse" /> class.
        /// </summary>
        public AssetAliasResponse()
        {
        }

    }
}