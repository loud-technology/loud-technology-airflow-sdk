
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Payload serializer for updating an XCom entry.
    /// </summary>
    public sealed partial class XComUpdateBody
    {
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
        /// Initializes a new instance of the <see cref="XComUpdateBody" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="mapIndex">
        /// Default Value: -1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public XComUpdateBody(
            object value,
            int? mapIndex)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.MapIndex = mapIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XComUpdateBody" /> class.
        /// </summary>
        public XComUpdateBody()
        {
        }

    }
}