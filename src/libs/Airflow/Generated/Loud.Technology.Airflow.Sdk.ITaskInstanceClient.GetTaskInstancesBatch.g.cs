#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface ITaskInstanceClient
    {
        /// <summary>
        /// Get Task Instances Batch<br/>
        /// Get list of task instances.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse> GetTaskInstancesBatchAsync(

            global::Loud.Technology.Airflow.Sdk.TaskInstancesBatchBody request,
            string dagId = "~",
            string dagRunId = "~",
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Task Instances Batch<br/>
        /// Get list of task instances.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse>> GetTaskInstancesBatchAsResponseAsync(

            global::Loud.Technology.Airflow.Sdk.TaskInstancesBatchBody request,
            string dagId = "~",
            string dagRunId = "~",
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Task Instances Batch<br/>
        /// Get list of task instances.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="dagIds"></param>
        /// <param name="dagRunIds"></param>
        /// <param name="taskIds"></param>
        /// <param name="state"></param>
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
        /// <param name="durationGte"></param>
        /// <param name="durationGt"></param>
        /// <param name="durationLte"></param>
        /// <param name="durationLt"></param>
        /// <param name="pool"></param>
        /// <param name="queue"></param>
        /// <param name="executor"></param>
        /// <param name="pageOffset">
        /// Default Value: 0
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 100
        /// </param>
        /// <param name="orderBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse> GetTaskInstancesBatchAsync(
            string dagId = "~",
            string dagRunId = "~",
            global::System.Collections.Generic.IList<string>? dagIds = default,
            global::System.Collections.Generic.IList<string>? dagRunIds = default,
            global::System.Collections.Generic.IList<string>? taskIds = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.TaskInstanceState>? state = default,
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
            double? durationGte = default,
            double? durationGt = default,
            double? durationLte = default,
            double? durationLt = default,
            global::System.Collections.Generic.IList<string>? pool = default,
            global::System.Collections.Generic.IList<string>? queue = default,
            global::System.Collections.Generic.IList<string>? executor = default,
            int? pageOffset = default,
            int? pageLimit = default,
            string? orderBy = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}