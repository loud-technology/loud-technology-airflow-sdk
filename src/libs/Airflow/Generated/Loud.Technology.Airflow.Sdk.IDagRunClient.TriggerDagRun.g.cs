#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagRunClient
    {
        /// <summary>
        /// Trigger Dag Run<br/>
        /// Trigger a DAG.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGRunResponse> TriggerDagRunAsync(
            object dagId,

            global::Loud.Technology.Airflow.Sdk.TriggerDAGRunPostBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Dag Run<br/>
        /// Trigger a DAG.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGRunResponse>> TriggerDagRunAsResponseAsync(
            object dagId,

            global::Loud.Technology.Airflow.Sdk.TriggerDAGRunPostBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger Dag Run<br/>
        /// Trigger a DAG.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="dataIntervalStart"></param>
        /// <param name="dataIntervalEnd"></param>
        /// <param name="logicalDate"></param>
        /// <param name="runAfter"></param>
        /// <param name="conf"></param>
        /// <param name="note"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGRunResponse> TriggerDagRunAsync(
            object dagId,
            string? dagRunId = default,
            global::System.DateTime? dataIntervalStart = default,
            global::System.DateTime? dataIntervalEnd = default,
            global::System.DateTime? logicalDate = default,
            global::System.DateTime? runAfter = default,
            object? conf = default,
            string? note = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}