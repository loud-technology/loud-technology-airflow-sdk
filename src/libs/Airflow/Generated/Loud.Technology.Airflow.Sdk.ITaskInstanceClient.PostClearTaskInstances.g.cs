#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface ITaskInstanceClient
    {
        /// <summary>
        /// Post Clear Task Instances<br/>
        /// Clear task instances.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse> PostClearTaskInstancesAsync(
            string dagId,

            global::Loud.Technology.Airflow.Sdk.ClearTaskInstancesBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post Clear Task Instances<br/>
        /// Clear task instances.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse>> PostClearTaskInstancesAsResponseAsync(
            string dagId,

            global::Loud.Technology.Airflow.Sdk.ClearTaskInstancesBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Post Clear Task Instances<br/>
        /// Clear task instances.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dryRun">
        /// Default Value: true
        /// </param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="onlyFailed">
        /// Default Value: true
        /// </param>
        /// <param name="onlyRunning">
        /// Default Value: false
        /// </param>
        /// <param name="resetDagRuns">
        /// Default Value: true
        /// </param>
        /// <param name="taskIds">
        /// A list of `task_id` or [`task_id`, `map_index`]. If only the `task_id` is provided for a mapped task, all of its map indices will be targeted.
        /// </param>
        /// <param name="dagRunId"></param>
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
        /// <param name="runOnLatestVersion">
        /// (Experimental) Run on the latest bundle version of the dag after clearing the task instances.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse> PostClearTaskInstancesAsync(
            string dagId,
            bool? dryRun = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            bool? onlyFailed = default,
            bool? onlyRunning = default,
            bool? resetDagRuns = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.AnyOf<string, int?>>>>? taskIds = default,
            string? dagRunId = default,
            bool? includeUpstream = default,
            bool? includeDownstream = default,
            bool? includeFuture = default,
            bool? includePast = default,
            bool? runOnLatestVersion = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}