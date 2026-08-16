
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Filter Dags by having import errors. Only Dags that have been successfully loaded before will be returned.
    /// </summary>
    public sealed partial class GetDagsHasImportErrors
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}