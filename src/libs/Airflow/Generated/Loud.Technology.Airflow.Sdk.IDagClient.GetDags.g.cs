#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagClient
    {
        /// <summary>
        /// Get Dags<br/>
        /// Get all DAGs.
        /// </summary>
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
        /// <param name="dagDisplayNamePattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="excludeStale">
        /// Default Value: true
        /// </param>
        /// <param name="paused"></param>
        /// <param name="hasImportErrors">
        /// Filter Dags by having import errors. Only Dags that have been successfully loaded before will be returned.
        /// </param>
        /// <param name="lastDagRunState"></param>
        /// <param name="bundleName"></param>
        /// <param name="bundleVersion"></param>
        /// <param name="hasAssetSchedule">
        /// Filter Dags with asset-based scheduling
        /// </param>
        /// <param name="assetDependency">
        /// Filter Dags by asset dependency (name or URI)
        /// </param>
        /// <param name="dagRunStartDateGte"></param>
        /// <param name="dagRunStartDateGt"></param>
        /// <param name="dagRunStartDateLte"></param>
        /// <param name="dagRunStartDateLt"></param>
        /// <param name="dagRunEndDateGte"></param>
        /// <param name="dagRunEndDateGt"></param>
        /// <param name="dagRunEndDateLte"></param>
        /// <param name="dagRunEndDateLt"></param>
        /// <param name="dagRunState"></param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `dag_id, dag_display_name, next_dagrun, state, start_date, last_run_state, last_run_start_date`<br/>
        /// Default Value: [dag_id]
        /// </param>
        /// <param name="isFavorite"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse> GetDagsAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Loud.Technology.Airflow.Sdk.GetDagsTagsMatchMode2? tagsMatchMode = default,
            global::System.Collections.Generic.IList<string>? owners = default,
            string? dagIdPattern = default,
            string? dagDisplayNamePattern = default,
            bool? excludeStale = default,
            bool? paused = default,
            bool? hasImportErrors = default,
            global::Loud.Technology.Airflow.Sdk.DagRunState? lastDagRunState = default,
            string? bundleName = default,
            string? bundleVersion = default,
            bool? hasAssetSchedule = default,
            string? assetDependency = default,
            global::System.DateTime? dagRunStartDateGte = default,
            global::System.DateTime? dagRunStartDateGt = default,
            global::System.DateTime? dagRunStartDateLte = default,
            global::System.DateTime? dagRunStartDateLt = default,
            global::System.DateTime? dagRunEndDateGte = default,
            global::System.DateTime? dagRunEndDateGt = default,
            global::System.DateTime? dagRunEndDateLte = default,
            global::System.DateTime? dagRunEndDateLt = default,
            global::System.Collections.Generic.IList<string>? dagRunState = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            bool? isFavorite = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dags<br/>
        /// Get all DAGs.
        /// </summary>
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
        /// <param name="dagDisplayNamePattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="excludeStale">
        /// Default Value: true
        /// </param>
        /// <param name="paused"></param>
        /// <param name="hasImportErrors">
        /// Filter Dags by having import errors. Only Dags that have been successfully loaded before will be returned.
        /// </param>
        /// <param name="lastDagRunState"></param>
        /// <param name="bundleName"></param>
        /// <param name="bundleVersion"></param>
        /// <param name="hasAssetSchedule">
        /// Filter Dags with asset-based scheduling
        /// </param>
        /// <param name="assetDependency">
        /// Filter Dags by asset dependency (name or URI)
        /// </param>
        /// <param name="dagRunStartDateGte"></param>
        /// <param name="dagRunStartDateGt"></param>
        /// <param name="dagRunStartDateLte"></param>
        /// <param name="dagRunStartDateLt"></param>
        /// <param name="dagRunEndDateGte"></param>
        /// <param name="dagRunEndDateGt"></param>
        /// <param name="dagRunEndDateLte"></param>
        /// <param name="dagRunEndDateLt"></param>
        /// <param name="dagRunState"></param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `dag_id, dag_display_name, next_dagrun, state, start_date, last_run_state, last_run_start_date`<br/>
        /// Default Value: [dag_id]
        /// </param>
        /// <param name="isFavorite"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse>> GetDagsAsResponseAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Loud.Technology.Airflow.Sdk.GetDagsTagsMatchMode2? tagsMatchMode = default,
            global::System.Collections.Generic.IList<string>? owners = default,
            string? dagIdPattern = default,
            string? dagDisplayNamePattern = default,
            bool? excludeStale = default,
            bool? paused = default,
            bool? hasImportErrors = default,
            global::Loud.Technology.Airflow.Sdk.DagRunState? lastDagRunState = default,
            string? bundleName = default,
            string? bundleVersion = default,
            bool? hasAssetSchedule = default,
            string? assetDependency = default,
            global::System.DateTime? dagRunStartDateGte = default,
            global::System.DateTime? dagRunStartDateGt = default,
            global::System.DateTime? dagRunStartDateLte = default,
            global::System.DateTime? dagRunStartDateLt = default,
            global::System.DateTime? dagRunEndDateGte = default,
            global::System.DateTime? dagRunEndDateGt = default,
            global::System.DateTime? dagRunEndDateLte = default,
            global::System.DateTime? dagRunEndDateLt = default,
            global::System.Collections.Generic.IList<string>? dagRunState = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            bool? isFavorite = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}