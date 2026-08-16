
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Pool serializer for post bodies.
    /// </summary>
    public sealed partial class PoolBody
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
        [global::System.Text.Json.Serialization.JsonPropertyName("slots")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Slots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_deferred")]
        public bool? IncludeDeferred { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolBody" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="slots"></param>
        /// <param name="description"></param>
        /// <param name="includeDeferred">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PoolBody(
            string name,
            int slots,
            string? description,
            bool? includeDeferred)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slots = slots;
            this.Description = description;
            this.IncludeDeferred = includeDeferred;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolBody" /> class.
        /// </summary>
        public PoolBody()
        {
        }

    }
}