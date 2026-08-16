#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagVersionClient
    {
        /// <summary>
        /// Get Dag Versions<br/>
        /// Get all DAG Versions.<br/>
        /// This endpoint allows specifying `~` as the dag_id to retrieve DAG Versions for all DAGs.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="versionNumber"></param>
        /// <param name="bundleName"></param>
        /// <param name="bundleVersion"></param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, version_number, bundle_name, bundle_version`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGVersionCollectionResponse> GetDagVersionsAsync(
            string dagId,
            int? limit = default,
            int? offset = default,
            int? versionNumber = default,
            string? bundleName = default,
            string? bundleVersion = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dag Versions<br/>
        /// Get all DAG Versions.<br/>
        /// This endpoint allows specifying `~` as the dag_id to retrieve DAG Versions for all DAGs.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="versionNumber"></param>
        /// <param name="bundleName"></param>
        /// <param name="bundleVersion"></param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, version_number, bundle_name, bundle_version`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGVersionCollectionResponse>> GetDagVersionsAsResponseAsync(
            string dagId,
            int? limit = default,
            int? offset = default,
            int? versionNumber = default,
            string? bundleName = default,
            string? bundleVersion = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}