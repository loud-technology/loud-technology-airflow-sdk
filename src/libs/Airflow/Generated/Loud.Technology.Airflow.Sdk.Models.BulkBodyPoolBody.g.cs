
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkBodyPoolBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionPoolBody>> Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkBodyPoolBody" /> class.
        /// </summary>
        /// <param name="actions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkBodyPoolBody(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionPoolBody>> actions)
        {
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkBodyPoolBody" /> class.
        /// </summary>
        public BulkBodyPoolBody()
        {
        }

    }
}