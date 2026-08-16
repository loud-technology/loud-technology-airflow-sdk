#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagStatsClient
    {
        /// <summary>
        /// Get Dag Stats<br/>
        /// Get Dag statistics.
        /// </summary>
        /// <param name="dagIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DagStatsCollectionResponse> GetDagStatsAsync(
            global::System.Collections.Generic.IList<string>? dagIds = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dag Stats<br/>
        /// Get Dag statistics.
        /// </summary>
        /// <param name="dagIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DagStatsCollectionResponse>> GetDagStatsAsResponseAsync(
            global::System.Collections.Generic.IList<string>? dagIds = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}