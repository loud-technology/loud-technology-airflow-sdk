#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagVersionClient
    {
        /// <summary>
        /// Get Dag Version<br/>
        /// Get one Dag Version.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="versionNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DagVersionResponse> GetDagVersionAsync(
            string dagId,
            int versionNumber,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dag Version<br/>
        /// Get one Dag Version.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="versionNumber"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DagVersionResponse>> GetDagVersionAsResponseAsync(
            string dagId,
            int versionNumber,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}