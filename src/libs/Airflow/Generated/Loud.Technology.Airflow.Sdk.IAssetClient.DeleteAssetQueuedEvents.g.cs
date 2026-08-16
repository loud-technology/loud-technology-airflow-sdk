#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IAssetClient
    {
        /// <summary>
        /// Delete Asset Queued Events<br/>
        /// Delete queued asset events for an asset.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAssetQueuedEventsAsync(
            int assetId,
            string? before = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Asset Queued Events<br/>
        /// Delete queued asset events for an asset.
        /// </summary>
        /// <param name="assetId"></param>
        /// <param name="before"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse> DeleteAssetQueuedEventsAsResponseAsync(
            int assetId,
            string? before = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}