
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Pool serializer for patch bodies.
    /// </summary>
    public sealed partial class PoolPatchBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pool")]
        public string? Pool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slots")]
        public int? Slots { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_deferred")]
        public bool? IncludeDeferred { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolPatchBody" /> class.
        /// </summary>
        /// <param name="pool"></param>
        /// <param name="slots"></param>
        /// <param name="description"></param>
        /// <param name="includeDeferred"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PoolPatchBody(
            string? pool,
            int? slots,
            string? description,
            bool? includeDeferred)
        {
            this.Pool = pool;
            this.Slots = slots;
            this.Description = description;
            this.IncludeDeferred = includeDeferred;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolPatchBody" /> class.
        /// </summary>
        public PoolPatchBody()
        {
        }

    }
}