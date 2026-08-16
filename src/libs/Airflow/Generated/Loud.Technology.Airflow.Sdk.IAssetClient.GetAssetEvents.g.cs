#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IAssetClient
    {
        /// <summary>
        /// Get Asset Events<br/>
        /// Get asset events.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `source_task_id, source_dag_id, source_run_id, source_map_index, timestamp`<br/>
        /// Default Value: [timestamp]
        /// </param>
        /// <param name="assetId"></param>
        /// <param name="sourceDagId"></param>
        /// <param name="sourceTaskId"></param>
        /// <param name="sourceRunId"></param>
        /// <param name="sourceMapIndex"></param>
        /// <param name="timestampGte"></param>
        /// <param name="timestampGt"></param>
        /// <param name="timestampLte"></param>
        /// <param name="timestampLt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AssetEventCollectionResponse> GetAssetEventsAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            int? assetId = default,
            string? sourceDagId = default,
            string? sourceTaskId = default,
            string? sourceRunId = default,
            int? sourceMapIndex = default,
            global::System.DateTime? timestampGte = default,
            global::System.DateTime? timestampGt = default,
            global::System.DateTime? timestampLte = default,
            global::System.DateTime? timestampLt = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Asset Events<br/>
        /// Get asset events.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `source_task_id, source_dag_id, source_run_id, source_map_index, timestamp`<br/>
        /// Default Value: [timestamp]
        /// </param>
        /// <param name="assetId"></param>
        /// <param name="sourceDagId"></param>
        /// <param name="sourceTaskId"></param>
        /// <param name="sourceRunId"></param>
        /// <param name="sourceMapIndex"></param>
        /// <param name="timestampGte"></param>
        /// <param name="timestampGt"></param>
        /// <param name="timestampLte"></param>
        /// <param name="timestampLt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.AssetEventCollectionResponse>> GetAssetEventsAsResponseAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            int? assetId = default,
            string? sourceDagId = default,
            string? sourceTaskId = default,
            string? sourceRunId = default,
            int? sourceMapIndex = default,
            global::System.DateTime? timestampGte = default,
            global::System.DateTime? timestampGt = default,
            global::System.DateTime? timestampLte = default,
            global::System.DateTime? timestampLt = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}