
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkBodyConnectionBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionConnectionBody>> Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkBodyConnectionBody" /> class.
        /// </summary>
        /// <param name="actions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkBodyConnectionBody(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionConnectionBody>> actions)
        {
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkBodyConnectionBody" /> class.
        /// </summary>
        public BulkBodyConnectionBody()
        {
        }

    }
}