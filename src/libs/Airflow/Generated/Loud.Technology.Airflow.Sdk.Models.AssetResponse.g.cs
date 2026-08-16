
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// Asset serializer for responses.
    /// </summary>
    public sealed partial class AssetResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Group { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_dags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagScheduleAssetReference> ScheduledDags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("producing_tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskOutletAssetReference> ProducingTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consuming_tasks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskInletAssetReference> ConsumingTasks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AssetAliasResponse> Aliases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_asset_event")]
        public global::Loud.Technology.Airflow.Sdk.LastAssetEventResponse? LastAssetEvent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="uri"></param>
        /// <param name="group"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="scheduledDags"></param>
        /// <param name="producingTasks"></param>
        /// <param name="consumingTasks"></param>
        /// <param name="aliases"></param>
        /// <param name="extra"></param>
        /// <param name="lastAssetEvent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssetResponse(
            int id,
            string name,
            string uri,
            string group,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagScheduleAssetReference> scheduledDags,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskOutletAssetReference> producingTasks,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskInletAssetReference> consumingTasks,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AssetAliasResponse> aliases,
            object? extra,
            global::Loud.Technology.Airflow.Sdk.LastAssetEventResponse? lastAssetEvent)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
            this.Extra = extra;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ScheduledDags = scheduledDags ?? throw new global::System.ArgumentNullException(nameof(scheduledDags));
            this.ProducingTasks = producingTasks ?? throw new global::System.ArgumentNullException(nameof(producingTasks));
            this.ConsumingTasks = consumingTasks ?? throw new global::System.ArgumentNullException(nameof(consumingTasks));
            this.Aliases = aliases ?? throw new global::System.ArgumentNullException(nameof(aliases));
            this.LastAssetEvent = lastAssetEvent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssetResponse" /> class.
        /// </summary>
        public AssetResponse()
        {
        }

    }
}