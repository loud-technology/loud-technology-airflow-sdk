
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkCreateActionBulkTaskInstanceBody
    {
        /// <summary>
        /// The action to be performed on the entities.
        /// </summary>
        /// <default>"create"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "create";

        /// <summary>
        /// A list of entities to be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody> Entities { get; set; }

        /// <summary>
        /// Bulk Action to be taken if the entity already exists or not.<br/>
        /// Default Value: fail
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_on_existence")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.BulkActionOnExistenceJsonConverter))]
        public global::Loud.Technology.Airflow.Sdk.BulkActionOnExistence? ActionOnExistence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateActionBulkTaskInstanceBody" /> class.
        /// </summary>
        /// <param name="entities">
        /// A list of entities to be created.
        /// </param>
        /// <param name="actionOnExistence">
        /// Bulk Action to be taken if the entity already exists or not.<br/>
        /// Default Value: fail
        /// </param>
        /// <param name="action">
        /// The action to be performed on the entities.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkCreateActionBulkTaskInstanceBody(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody> entities,
            global::Loud.Technology.Airflow.Sdk.BulkActionOnExistence? actionOnExistence,
            string action = "create")
        {
            this.Action = action;
            this.Entities = entities ?? throw new global::System.ArgumentNullException(nameof(entities));
            this.ActionOnExistence = actionOnExistence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkCreateActionBulkTaskInstanceBody" /> class.
        /// </summary>
        public BulkCreateActionBulkTaskInstanceBody()
        {
        }

    }
}