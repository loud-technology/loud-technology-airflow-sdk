#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface ITaskInstanceClient
    {
        /// <summary>
        /// Get Mapped Task Instances<br/>
        /// Get list of mapped task instances.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="runAfterGte"></param>
        /// <param name="runAfterGt"></param>
        /// <param name="runAfterLte"></param>
        /// <param name="runAfterLt"></param>
        /// <param name="logicalDateGte"></param>
        /// <param name="logicalDateGt"></param>
        /// <param name="logicalDateLte"></param>
        /// <param name="logicalDateLt"></param>
        /// <param name="startDateGte"></param>
        /// <param name="startDateGt"></param>
        /// <param name="startDateLte"></param>
        /// <param name="startDateLt"></param>
        /// <param name="endDateGte"></param>
        /// <param name="endDateGt"></param>
        /// <param name="endDateLte"></param>
        /// <param name="endDateLt"></param>
        /// <param name="updatedAtGte"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLte"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="durationGte"></param>
        /// <param name="durationGt"></param>
        /// <param name="durationLte"></param>
        /// <param name="durationLt"></param>
        /// <param name="state"></param>
        /// <param name="pool"></param>
        /// <param name="queue"></param>
        /// <param name="executor"></param>
        /// <param name="versionNumber"></param>
        /// <param name="tryNumber"></param>
        /// <param name="operator"></param>
        /// <param name="mapIndex"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, state, duration, start_date, end_date, map_index, try_number, logical_date, run_after, data_interval_start, data_interval_end, rendered_map_index, operator, run_after, logical_date, data_interval_start, data_interval_end`<br/>
        /// Default Value: [map_index]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse> GetMappedTaskInstancesAsync(
            string dagId,
            string dagRunId,
            string taskId,
            global::System.DateTime? runAfterGte = default,
            global::System.DateTime? runAfterGt = default,
            global::System.DateTime? runAfterLte = default,
            global::System.DateTime? runAfterLt = default,
            global::System.DateTime? logicalDateGte = default,
            global::System.DateTime? logicalDateGt = default,
            global::System.DateTime? logicalDateLte = default,
            global::System.DateTime? logicalDateLt = default,
            global::System.DateTime? startDateGte = default,
            global::System.DateTime? startDateGt = default,
            global::System.DateTime? startDateLte = default,
            global::System.DateTime? startDateLt = default,
            global::System.DateTime? endDateGte = default,
            global::System.DateTime? endDateGt = default,
            global::System.DateTime? endDateLte = default,
            global::System.DateTime? endDateLt = default,
            global::System.DateTime? updatedAtGte = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLte = default,
            global::System.DateTime? updatedAtLt = default,
            double? durationGte = default,
            double? durationGt = default,
            double? durationLte = default,
            double? durationLt = default,
            global::System.Collections.Generic.IList<string>? state = default,
            global::System.Collections.Generic.IList<string>? pool = default,
            global::System.Collections.Generic.IList<string>? queue = default,
            global::System.Collections.Generic.IList<string>? executor = default,
            global::System.Collections.Generic.IList<int>? versionNumber = default,
            global::System.Collections.Generic.IList<int>? tryNumber = default,
            global::System.Collections.Generic.IList<string>? @operator = default,
            global::System.Collections.Generic.IList<int>? mapIndex = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Mapped Task Instances<br/>
        /// Get list of mapped task instances.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="runAfterGte"></param>
        /// <param name="runAfterGt"></param>
        /// <param name="runAfterLte"></param>
        /// <param name="runAfterLt"></param>
        /// <param name="logicalDateGte"></param>
        /// <param name="logicalDateGt"></param>
        /// <param name="logicalDateLte"></param>
        /// <param name="logicalDateLt"></param>
        /// <param name="startDateGte"></param>
        /// <param name="startDateGt"></param>
        /// <param name="startDateLte"></param>
        /// <param name="startDateLt"></param>
        /// <param name="endDateGte"></param>
        /// <param name="endDateGt"></param>
        /// <param name="endDateLte"></param>
        /// <param name="endDateLt"></param>
        /// <param name="updatedAtGte"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLte"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="durationGte"></param>
        /// <param name="durationGt"></param>
        /// <param name="durationLte"></param>
        /// <param name="durationLt"></param>
        /// <param name="state"></param>
        /// <param name="pool"></param>
        /// <param name="queue"></param>
        /// <param name="executor"></param>
        /// <param name="versionNumber"></param>
        /// <param name="tryNumber"></param>
        /// <param name="operator"></param>
        /// <param name="mapIndex"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, state, duration, start_date, end_date, map_index, try_number, logical_date, run_after, data_interval_start, data_interval_end, rendered_map_index, operator, run_after, logical_date, data_interval_start, data_interval_end`<br/>
        /// Default Value: [map_index]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse>> GetMappedTaskInstancesAsResponseAsync(
            string dagId,
            string dagRunId,
            string taskId,
            global::System.DateTime? runAfterGte = default,
            global::System.DateTime? runAfterGt = default,
            global::System.DateTime? runAfterLte = default,
            global::System.DateTime? runAfterLt = default,
            global::System.DateTime? logicalDateGte = default,
            global::System.DateTime? logicalDateGt = default,
            global::System.DateTime? logicalDateLte = default,
            global::System.DateTime? logicalDateLt = default,
            global::System.DateTime? startDateGte = default,
            global::System.DateTime? startDateGt = default,
            global::System.DateTime? startDateLte = default,
            global::System.DateTime? startDateLt = default,
            global::System.DateTime? endDateGte = default,
            global::System.DateTime? endDateGt = default,
            global::System.DateTime? endDateLte = default,
            global::System.DateTime? endDateLt = default,
            global::System.DateTime? updatedAtGte = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLte = default,
            global::System.DateTime? updatedAtLt = default,
            double? durationGte = default,
            double? durationGt = default,
            double? durationLte = default,
            double? durationLt = default,
            global::System.Collections.Generic.IList<string>? state = default,
            global::System.Collections.Generic.IList<string>? pool = default,
            global::System.Collections.Generic.IList<string>? queue = default,
            global::System.Collections.Generic.IList<string>? executor = default,
            global::System.Collections.Generic.IList<int>? versionNumber = default,
            global::System.Collections.Generic.IList<int>? tryNumber = default,
            global::System.Collections.Generic.IList<string>? @operator = default,
            global::System.Collections.Generic.IList<int>? mapIndex = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}