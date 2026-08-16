
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkBodyBulkTaskInstanceBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionBulkTaskInstanceBody>> Actions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkBodyBulkTaskInstanceBody" /> class.
        /// </summary>
        /// <param name="actions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkBodyBulkTaskInstanceBody(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionBulkTaskInstanceBody>> actions)
        {
            this.Actions = actions ?? throw new global::System.ArgumentNullException(nameof(actions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkBodyBulkTaskInstanceBody" /> class.
        /// </summary>
        public BulkBodyBulkTaskInstanceBody()
        {
        }

    }
}