#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface ITaskInstanceClient
    {
        /// <summary>
        /// Patch Task Instance Dry Run<br/>
        /// Update a task instance dry_run mode.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="mapIndex"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse> PatchTaskInstanceDryRunByMapIndexAsync(
            string dagId,
            string dagRunId,
            string taskId,
            int? mapIndex,

            global::Loud.Technology.Airflow.Sdk.PatchTaskInstanceBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Task Instance Dry Run<br/>
        /// Update a task instance dry_run mode.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="mapIndex"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse>> PatchTaskInstanceDryRunByMapIndexAsResponseAsync(
            string dagId,
            string dagRunId,
            string taskId,
            int? mapIndex,

            global::Loud.Technology.Airflow.Sdk.PatchTaskInstanceBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Task Instance Dry Run<br/>
        /// Update a task instance dry_run mode.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="mapIndex"></param>
        /// <param name="updateMask"></param>
        /// <param name="newState"></param>
        /// <param name="note"></param>
        /// <param name="includeUpstream">
        /// Default Value: false
        /// </param>
        /// <param name="includeDownstream">
        /// Default Value: false
        /// </param>
        /// <param name="includeFuture">
        /// Default Value: false
        /// </param>
        /// <param name="includePast">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse> PatchTaskInstanceDryRunByMapIndexAsync(
            string dagId,
            string dagRunId,
            string taskId,
            int? mapIndex,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.TaskInstanceState? newState = default,
            string? note = default,
            bool? includeUpstream = default,
            bool? includeDownstream = default,
            bool? includeFuture = default,
            bool? includePast = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}