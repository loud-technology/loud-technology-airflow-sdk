#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IXComClient
    {
        /// <summary>
        /// Get Xcom Entries<br/>
        /// Get all XCom entries.<br/>
        /// This endpoint allows specifying `~` as the dag_id, dag_run_id, task_id to retrieve XCom entries for all DAGs.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="xcomKey"></param>
        /// <param name="mapIndex"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="xcomKeyPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="dagDisplayNamePattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="runIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="taskIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="mapIndexFilter"></param>
        /// <param name="logicalDateGte"></param>
        /// <param name="logicalDateGt"></param>
        /// <param name="logicalDateLte"></param>
        /// <param name="logicalDateLt"></param>
        /// <param name="runAfterGte"></param>
        /// <param name="runAfterGt"></param>
        /// <param name="runAfterLte"></param>
        /// <param name="runAfterLt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.XComCollectionResponse> GetXcomEntriesAsync(
            string dagId,
            string dagRunId,
            string taskId,
            string? xcomKey = default,
            int? mapIndex = default,
            int? limit = default,
            int? offset = default,
            string? xcomKeyPattern = default,
            string? dagDisplayNamePattern = default,
            string? runIdPattern = default,
            string? taskIdPattern = default,
            int? mapIndexFilter = default,
            global::System.DateTime? logicalDateGte = default,
            global::System.DateTime? logicalDateGt = default,
            global::System.DateTime? logicalDateLte = default,
            global::System.DateTime? logicalDateLt = default,
            global::System.DateTime? runAfterGte = default,
            global::System.DateTime? runAfterGt = default,
            global::System.DateTime? runAfterLte = default,
            global::System.DateTime? runAfterLt = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Xcom Entries<br/>
        /// Get all XCom entries.<br/>
        /// This endpoint allows specifying `~` as the dag_id, dag_run_id, task_id to retrieve XCom entries for all DAGs.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="xcomKey"></param>
        /// <param name="mapIndex"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="xcomKeyPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="dagDisplayNamePattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="runIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="taskIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="mapIndexFilter"></param>
        /// <param name="logicalDateGte"></param>
        /// <param name="logicalDateGt"></param>
        /// <param name="logicalDateLte"></param>
        /// <param name="logicalDateLt"></param>
        /// <param name="runAfterGte"></param>
        /// <param name="runAfterGt"></param>
        /// <param name="runAfterLte"></param>
        /// <param name="runAfterLt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.XComCollectionResponse>> GetXcomEntriesAsResponseAsync(
            string dagId,
            string dagRunId,
            string taskId,
            string? xcomKey = default,
            int? mapIndex = default,
            int? limit = default,
            int? offset = default,
            string? xcomKeyPattern = default,
            string? dagDisplayNamePattern = default,
            string? runIdPattern = default,
            string? taskIdPattern = default,
            int? mapIndexFilter = default,
            global::System.DateTime? logicalDateGte = default,
            global::System.DateTime? logicalDateGt = default,
            global::System.DateTime? logicalDateLte = default,
            global::System.DateTime? logicalDateLt = default,
            global::System.DateTime? runAfterGte = default,
            global::System.DateTime? runAfterGt = default,
            global::System.DateTime? runAfterLte = default,
            global::System.DateTime? runAfterLt = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}