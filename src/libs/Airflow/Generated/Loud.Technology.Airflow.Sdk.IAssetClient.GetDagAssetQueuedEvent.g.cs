#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IAssetClient
    {
        /// <summary>
        /// Get Dag Asset Queued Event<br/>
        /// Get a queued asset event for a DAG.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="assetId"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.QueuedEventResponse> GetDagAssetQueuedEventAsync(
            string dagId,
            int assetId,
            string? before = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dag Asset Queued Event<br/>
        /// Get a queued asset event for a DAG.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="assetId"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.QueuedEventResponse>> GetDagAssetQueuedEventAsResponseAsync(
            string dagId,
            int assetId,
            string? before = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}