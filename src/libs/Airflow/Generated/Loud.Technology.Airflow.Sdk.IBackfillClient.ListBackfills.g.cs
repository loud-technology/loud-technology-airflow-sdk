#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IBackfillClient
    {
        /// <summary>
        /// List Backfills
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.BackfillCollectionResponse> ListBackfillsAsync(
            string dagId,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List Backfills
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.BackfillCollectionResponse>> ListBackfillsAsResponseAsync(
            string dagId,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}