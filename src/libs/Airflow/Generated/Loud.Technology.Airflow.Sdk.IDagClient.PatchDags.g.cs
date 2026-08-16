#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagClient
    {
        /// <summary>
        /// Patch Dags<br/>
        /// Patch multiple DAGs.
        /// </summary>
        /// <param name="updateMask"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tags"></param>
        /// <param name="tagsMatchMode"></param>
        /// <param name="owners"></param>
        /// <param name="dagIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="excludeStale">
        /// Default Value: true
        /// </param>
        /// <param name="paused"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse> PatchDagsAsync(

            global::Loud.Technology.Airflow.Sdk.DAGPatchBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Loud.Technology.Airflow.Sdk.PatchDagsTagsMatchMode2? tagsMatchMode = default,
            global::System.Collections.Generic.IList<string>? owners = default,
            string? dagIdPattern = default,
            bool? excludeStale = default,
            bool? paused = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Dags<br/>
        /// Patch multiple DAGs.
        /// </summary>
        /// <param name="updateMask"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tags"></param>
        /// <param name="tagsMatchMode"></param>
        /// <param name="owners"></param>
        /// <param name="dagIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="excludeStale">
        /// Default Value: true
        /// </param>
        /// <param name="paused"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse>> PatchDagsAsResponseAsync(

            global::Loud.Technology.Airflow.Sdk.DAGPatchBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Loud.Technology.Airflow.Sdk.PatchDagsTagsMatchMode2? tagsMatchMode = default,
            global::System.Collections.Generic.IList<string>? owners = default,
            string? dagIdPattern = default,
            bool? excludeStale = default,
            bool? paused = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Dags<br/>
        /// Patch multiple DAGs.
        /// </summary>
        /// <param name="updateMask"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tags"></param>
        /// <param name="tagsMatchMode"></param>
        /// <param name="owners"></param>
        /// <param name="dagIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="excludeStale">
        /// Default Value: true
        /// </param>
        /// <param name="paused"></param>
        /// <param name="isPaused"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse> PatchDagsAsync(
            bool isPaused,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Loud.Technology.Airflow.Sdk.PatchDagsTagsMatchMode2? tagsMatchMode = default,
            global::System.Collections.Generic.IList<string>? owners = default,
            string? dagIdPattern = default,
            bool? excludeStale = default,
            bool? paused = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}