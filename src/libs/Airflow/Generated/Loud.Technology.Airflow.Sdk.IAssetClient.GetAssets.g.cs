#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IAssetClient
    {
        /// <summary>
        /// Get Assets<br/>
        /// Get assets.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="namePattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="uriPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="dagIds"></param>
        /// <param name="onlyActive">
        /// Default Value: true
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, name, uri, created_at, updated_at`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AssetCollectionResponse> GetAssetsAsync(
            int? limit = default,
            int? offset = default,
            string? namePattern = default,
            string? uriPattern = default,
            global::System.Collections.Generic.IList<string>? dagIds = default,
            bool? onlyActive = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Assets<br/>
        /// Get assets.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="namePattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="uriPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="dagIds"></param>
        /// <param name="onlyActive">
        /// Default Value: true
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, name, uri, created_at, updated_at`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.AssetCollectionResponse>> GetAssetsAsResponseAsync(
            int? limit = default,
            int? offset = default,
            string? namePattern = default,
            string? uriPattern = default,
            global::System.Collections.Generic.IList<string>? dagIds = default,
            bool? onlyActive = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}