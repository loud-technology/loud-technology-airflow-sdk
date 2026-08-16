#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagRunClient
    {
        /// <summary>
        /// Get Upstream Asset Events<br/>
        /// If dag run is asset-triggered, return the asset events that triggered it.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AssetEventCollectionResponse> GetUpstreamAssetEventsAsync(
            string dagId,
            string dagRunId,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Upstream Asset Events<br/>
        /// If dag run is asset-triggered, return the asset events that triggered it.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.AssetEventCollectionResponse>> GetUpstreamAssetEventsAsResponseAsync(
            string dagId,
            string dagRunId,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}