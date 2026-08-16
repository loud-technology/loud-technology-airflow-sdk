
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateActionBulkTaskInstanceBody
    {
        /// <summary>
        /// The action to be performed on the entities.
        /// </summary>
        /// <default>"update"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "update";

        /// <summary>
        /// A list of entities to be updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody> Entities { get; set; }

        /// <summary>
        /// Bulk Action to be taken if the entity does not exist.<br/>
        /// Default Value: fail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_on_non_existence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.BulkActionNotOnExistenceJsonConverter))]
        public global::Loud.Technology.Airflow.Sdk.BulkActionNotOnExistence? ActionOnNonExistence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateActionBulkTaskInstanceBody" /> class.
        /// </summary>
        /// <param name="entities">
        /// A list of entities to be updated.
        /// </param>
        /// <param name="actionOnNonExistence">
        /// Bulk Action to be taken if the entity does not exist.<br/>
        /// Default Value: fail
        /// </param>
        /// <param name="action">
        /// The action to be performed on the entities.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateActionBulkTaskInstanceBody(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody> entities,
            global::Loud.Technology.Airflow.Sdk.BulkActionNotOnExistence? actionOnNonExistence,
            string action = "update")
        {
            this.Action = action;
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
            this.ActionOnNonExistence = actionOnNonExistence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateActionBulkTaskInstanceBody" /> class.
        /// </summary>
        public BulkUpdateActionBulkTaskInstanceBody()
        {
        }

    }
}