
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Serializer for responses to bulk entity operations.<br/>
    /// This represents the results of create, update, and delete actions performed on entity in bulk.<br/>
    /// Each action (if requested) is represented as a field containing details about successful keys and any encountered errors.<br/>
    /// Fields are populated in the response only if the respective action was part of the request, else are set None.
    /// </summary>
    public sealed partial class BulkResponse
    {
        /// <summary>
        /// Details of the bulk create operation, including successful keys and errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create")]
        public global::Loud.Technology.Airflow.Sdk.BulkActionResponse? Create { get; set; }

        /// <summary>
        /// Details of the bulk update operation, including successful keys and errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("update")]
        public global::Loud.Technology.Airflow.Sdk.BulkActionResponse? Update { get; set; }

        /// <summary>
        /// Details of the bulk delete operation, including successful keys and errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete")]
        public global::Loud.Technology.Airflow.Sdk.BulkActionResponse? Delete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkResponse" /> class.
        /// </summary>
        /// <param name="create">
        /// Details of the bulk create operation, including successful keys and errors.
        /// </param>
        /// <param name="update">
        /// Details of the bulk update operation, including successful keys and errors.
        /// </param>
        /// <param name="delete">
        /// Details of the bulk delete operation, including successful keys and errors.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkResponse(
            global::Loud.Technology.Airflow.Sdk.BulkActionResponse? create,
            global::Loud.Technology.Airflow.Sdk.BulkActionResponse? update,
            global::Loud.Technology.Airflow.Sdk.BulkActionResponse? delete)
        {
            this.Create = create;
            this.Update = update;
            this.Delete = delete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkResponse" /> class.
        /// </summary>
        public BulkResponse()
        {
        }

    }
}