
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Loud.Technology.Airflow.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.BulkActionNotOnExistenceJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.BulkActionNotOnExistenceNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.BulkActionOnExistenceJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.BulkActionOnExistenceNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DAGRunPatchStatesJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DAGRunPatchStatesNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagRunStateJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagRunStateNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagRunTriggeredByTypeJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagRunTriggeredByTypeNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagRunTypeJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagRunTypeNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagWarningTypeJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.DagWarningTypeNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.ExternalViewResponseDestinationJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.ExternalViewResponseDestinationNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.ReactAppResponseDestinationJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.ReactAppResponseDestinationNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.ReprocessBehaviorJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.ReprocessBehaviorNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.TaskInstanceStateJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.TaskInstanceStateNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.GetDagSourceAcceptJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.GetDagSourceAcceptNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.GetConfigAcceptJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.GetConfigAcceptNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.GetConfigValueAcceptJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.GetConfigValueAcceptNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.GetDagsTagsMatchMode2JsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.GetDagsTagsMatchMode2NullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.PatchDagsTagsMatchMode2JsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.PatchDagsTagsMatchMode2NullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.GetLogAcceptJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.GetLogAcceptNullableJsonConverter),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.OneOfJsonConverter<global::Loud.Technology.Airflow.Sdk.BulkCreateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionBulkTaskInstanceBody>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.OneOfJsonConverter<global::Loud.Technology.Airflow.Sdk.BulkCreateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionConnectionBody>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.OneOfJsonConverter<global::Loud.Technology.Airflow.Sdk.BulkCreateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionPoolBody>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.OneOfJsonConverter<global::Loud.Technology.Airflow.Sdk.BulkCreateActionVariableBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionVariableBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionVariableBody>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<string, global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<string, global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<string, global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<string, global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, int?>>>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.StructuredLogMessage>, global::System.Collections.Generic.IList<string>>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse, global::Loud.Technology.Airflow.Sdk.DAGRunResponse>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.AnyOfJsonConverter<global::Loud.Technology.Airflow.Sdk.XComResponseNative, global::Loud.Technology.Airflow.Sdk.XComResponseString>),

            typeof(global::Loud.Technology.Airflow.Sdk.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AppBuilderMenuItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AppBuilderViewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AssetAliasCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AssetAliasResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AssetAliasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AssetCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AssetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AssetEventCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AssetEventResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AssetEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.JsonValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagRunAssetReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagRunAssetReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagScheduleAssetReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagScheduleAssetReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskOutletAssetReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskOutletAssetReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskInletAssetReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskInletAssetReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.LastAssetEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BackfillCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.BackfillResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BackfillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BackfillPostBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ReprocessBehavior), TypeInfoPropertyName = "ReprocessBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BaseInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkActionNotOnExistence), TypeInfoPropertyName = "BulkActionNotOnExistence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkActionOnExistence), TypeInfoPropertyName = "BulkActionOnExistence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkActionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkBodyBulkTaskInstanceBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionBulkTaskInstanceBody>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionBulkTaskInstanceBody>), TypeInfoPropertyName = "OneOfBulkCreateActionBulkTaskInstanceBodyBulkUpdateActionBulkTaskInstanceBodyBulkDeleteActionBulkTaskInstanceBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkCreateActionBulkTaskInstanceBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkUpdateActionBulkTaskInstanceBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkDeleteActionBulkTaskInstanceBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkBodyConnectionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionConnectionBody>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionConnectionBody>), TypeInfoPropertyName = "OneOfBulkCreateActionConnectionBodyBulkUpdateActionConnectionBodyBulkDeleteActionConnectionBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkCreateActionConnectionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkUpdateActionConnectionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkDeleteActionConnectionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkBodyPoolBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionPoolBody>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionPoolBody>), TypeInfoPropertyName = "OneOfBulkCreateActionPoolBodyBulkUpdateActionPoolBodyBulkDeleteActionPoolBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkCreateActionPoolBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkUpdateActionPoolBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkDeleteActionPoolBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkBodyVariableBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionVariableBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionVariableBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionVariableBody>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionVariableBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionVariableBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionVariableBody>), TypeInfoPropertyName = "OneOfBulkCreateActionVariableBodyBulkUpdateActionVariableBodyBulkDeleteActionVariableBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkCreateActionVariableBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkUpdateActionVariableBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkDeleteActionVariableBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ConnectionBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ConnectionBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.PoolBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.PoolBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.VariableBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.VariableBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody>), TypeInfoPropertyName = "AnyOfStringBulkTaskInstanceBody2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.BulkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskInstanceState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ClearTaskInstancesBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, int?>>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, int?>>>), TypeInfoPropertyName = "AnyOfStringIListAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ConfigSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ConfigSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ConfigOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ConfigOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ConnectionCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ConnectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ConnectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ConnectionTestResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.CreateAssetEventsBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DAGResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGDetailsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagTagResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagTagResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGPatchBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGRunClearBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGRunCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DAGRunResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGRunPatchBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGRunPatchStates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagRunType), TypeInfoPropertyName = "DagRunType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagRunState), TypeInfoPropertyName = "DagRunState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagRunTriggeredByType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagVersionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGRunsBatchBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagRunState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGSourceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGTagCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGVersionCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGWarningCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DAGWarningResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DAGWarningResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagWarningType), TypeInfoPropertyName = "DagWarningType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagProcessorInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagStatsCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagStatsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagStatsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagStatsStateResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DagStatsStateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DryRunBackfillCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DryRunBackfillResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.DryRunBackfillResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.EventLogCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.EventLogResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.EventLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ExternalLogUrlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ExternalViewResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ExternalViewResponseDestination), TypeInfoPropertyName = "ExternalViewResponseDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ExtraLinkCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.FastAPIAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.FastAPIRootMiddlewareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.HITLDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskInstanceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.HITLUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.HITLUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.HITLDetailCollection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.HITLDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.HITLDetailResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AnyOf<string, object>), TypeInfoPropertyName = "AnyOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.HealthInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.SchedulerInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TriggererInfoResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ImportErrorCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ImportErrorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ImportErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.JobCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.JobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.JobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.PatchTaskInstanceBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.PluginCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.PluginResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.PluginResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.PluginImportErrorCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.PluginImportErrorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.PluginImportErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.FastAPIAppResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.FastAPIRootMiddlewareResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ExternalViewResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ReactAppResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ReactAppResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AppBuilderViewResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AppBuilderMenuItemResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.PoolCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.PoolResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.PoolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.PoolPatchBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ProviderCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.ProviderResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ProviderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.QueuedEventCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.QueuedEventResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.QueuedEventResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.ReactAppResponseDestination), TypeInfoPropertyName = "ReactAppResponseDestination2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.StructuredLogMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskDependencyCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskDependencyResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskDependencyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskInstanceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskInstanceHistoryCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskInstanceHistoryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskInstanceHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TriggerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskInstancesBatchBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskInstanceState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TaskInstancesLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AnyOf<global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.StructuredLogMessage>, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfIListStructuredLogMessageIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.StructuredLogMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TimeDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.TriggerDAGRunPostBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.UpdateHITLDetailPayload))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.VariableCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.VariableResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.VariableResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.VersionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.XComCollectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.XComResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.XComResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.XComCreateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.XComResponseNative))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.XComResponseString))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.XComUpdateBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.GetDagSourceAccept), TypeInfoPropertyName = "GetDagSourceAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.GetConfigAccept), TypeInfoPropertyName = "GetConfigAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.GetConfigValueAccept), TypeInfoPropertyName = "GetConfigValueAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.GetDagsTagsMatchMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.PatchDagsTagsMatchMode2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.GetLogAccept), TypeInfoPropertyName = "GetLogAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AnyOf<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse, global::Loud.Technology.Airflow.Sdk.DAGRunResponse>), TypeInfoPropertyName = "AnyOfTaskInstanceCollectionResponseDAGRunResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AnyOf<global::Loud.Technology.Airflow.Sdk.XComResponseNative, global::Loud.Technology.Airflow.Sdk.XComResponseString>), TypeInfoPropertyName = "AnyOfXComResponseNativeXComResponseString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionBulkTaskInstanceBody>?), TypeInfoPropertyName = "BulkDeleteActionBulkTaskInstanceBody_d940fe4f2c45613d")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.AssetAliasResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.AssetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.AssetEventResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.DagRunAssetReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.DagScheduleAssetReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.TaskOutletAssetReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.TaskInletAssetReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.BackfillResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionBulkTaskInstanceBody>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionConnectionBody>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionPoolBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionPoolBody>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionVariableBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionVariableBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionVariableBody>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.ConnectionBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.PoolBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.VariableBody>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::Loud.Technology.Airflow.Sdk.BulkTaskInstanceBody>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.AnyOf<string, int?>>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.AnyOf<string, int?>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.ConfigSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.ConfigOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.ConnectionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.DAGResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.DagTagResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.DAGRunResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.DagVersionResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.DagRunState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.DAGWarningResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.DagStatsResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.DagStatsStateResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.DryRunBackfillResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.EventLogResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.HITLUser>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.HITLDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.ImportErrorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.JobResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.PluginResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.PluginImportErrorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.FastAPIAppResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.FastAPIRootMiddlewareResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.ExternalViewResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.ReactAppResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.AppBuilderViewResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.AppBuilderMenuItemResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.PoolResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.ProviderResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.QueuedEventResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.TaskResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.TaskDependencyResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.TaskInstanceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.TaskInstanceHistoryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.TaskInstanceState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loud.Technology.Airflow.Sdk.AnyOf<global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.StructuredLogMessage>, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.StructuredLogMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.VariableResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loud.Technology.Airflow.Sdk.XComResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}