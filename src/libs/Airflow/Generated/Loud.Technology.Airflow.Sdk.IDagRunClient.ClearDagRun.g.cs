#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagRunClient
    {
        /// <summary>
        /// Clear Dag Run
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AnyOf<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse, global::Loud.Technology.Airflow.Sdk.DAGRunResponse>> ClearDagRunAsync(
            string dagId,
            string dagRunId,

            global::Loud.Technology.Airflow.Sdk.DAGRunClearBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear Dag Run
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.AnyOf<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse, global::Loud.Technology.Airflow.Sdk.DAGRunResponse>>> ClearDagRunAsResponseAsync(
            string dagId,
            string dagRunId,

            global::Loud.Technology.Airflow.Sdk.DAGRunClearBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clear Dag Run
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="dryRun">
        /// Default Value: true
        /// </param>
        /// <param name="onlyFailed">
        /// Default Value: false
        /// </param>
        /// <param name="runOnLatestVersion">
        /// (Experimental) Run on the latest bundle version of the Dag after clearing the Dag Run.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AnyOf<global::Loud.Technology.Airflow.Sdk.TaskInstanceCollectionResponse, global::Loud.Technology.Airflow.Sdk.DAGRunResponse>> ClearDagRunAsync(
            string dagId,
            string dagRunId,
            bool? dryRun = default,
            bool? onlyFailed = default,
            bool? runOnLatestVersion = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}