
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Pool Collection serializer for responses.
    /// </summary>
    public sealed partial class PoolCollectionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.PoolResponse> Pools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_entries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalEntries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolCollectionResponse" /> class.
        /// </summary>
        /// <param name="pools"></param>
        /// <param name="totalEntries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PoolCollectionResponse(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.PoolResponse> pools,
            int totalEntries)
        {
            this.Pools = pools ?? throw new global::System.ArgumentNullException(nameof(pools));
            this.TotalEntries = totalEntries;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolCollectionResponse" /> class.
        /// </summary>
        public PoolCollectionResponse()
        {
        }

    }
}