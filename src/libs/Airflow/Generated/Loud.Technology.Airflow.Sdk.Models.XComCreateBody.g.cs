
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Payload serializer for creating an XCom entry.
    /// </summary>
    public sealed partial class XComCreateBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("map_index")]
        public int? MapIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="XComCreateBody" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="mapIndex">
        /// Default Value: -1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XComCreateBody(
            string key,
            object value,
            int? mapIndex)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.MapIndex = mapIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XComCreateBody" /> class.
        /// </summary>
        public XComCreateBody()
        {
        }

    }
}