#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagRunClient
    {
        /// <summary>
        /// Patch Dag Run<br/>
        /// Modify a DAG Run.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGRunResponse> PatchDagRunAsync(
            string dagId,
            string dagRunId,

            global::Loud.Technology.Airflow.Sdk.DAGRunPatchBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Dag Run<br/>
        /// Modify a DAG Run.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGRunResponse>> PatchDagRunAsResponseAsync(
            string dagId,
            string dagRunId,

            global::Loud.Technology.Airflow.Sdk.DAGRunPatchBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Dag Run<br/>
        /// Modify a DAG Run.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="updateMask"></param>
        /// <param name="state"></param>
        /// <param name="note"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGRunResponse> PatchDagRunAsync(
            string dagId,
            string dagRunId,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.DAGRunPatchStates? state = default,
            string? note = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}