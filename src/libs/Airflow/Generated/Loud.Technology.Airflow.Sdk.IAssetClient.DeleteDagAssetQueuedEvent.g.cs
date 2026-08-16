#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IAssetClient
    {
        /// <summary>
        /// Delete Dag Asset Queued Event<br/>
        /// Delete a queued asset event for a DAG.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="assetId"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteDagAssetQueuedEventAsync(
            string dagId,
            int assetId,
            string? before = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Dag Asset Queued Event<br/>
        /// Delete a queued asset event for a DAG.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="assetId"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse> DeleteDagAssetQueuedEventAsResponseAsync(
            string dagId,
            int assetId,
            string? before = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}