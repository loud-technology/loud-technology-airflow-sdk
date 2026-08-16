#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface ITaskInstanceClient
    {
        /// <summary>
        /// Get Hitl Details<br/>
        /// Get Human-in-the-loop details.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `ti_id, subject, responded_at, created_at, responded_by_user_id, responded_by_user_name, dag_id, run_id, run_after, rendered_map_index, task_instance_operator, task_instance_state`<br/>
        /// Default Value: [ti_id]
        /// </param>
        /// <param name="dagIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="taskId"></param>
        /// <param name="taskIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="mapIndex"></param>
        /// <param name="state"></param>
        /// <param name="responseReceived"></param>
        /// <param name="respondedByUserId"></param>
        /// <param name="respondedByUserName"></param>
        /// <param name="subjectSearch">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="bodySearch">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="createdAtGte"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLte"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.HITLDetailCollection> GetHitlDetailsAsync(
            string dagId,
            string dagRunId,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            string? dagIdPattern = default,
            string? taskId = default,
            string? taskIdPattern = default,
            int? mapIndex = default,
            global::System.Collections.Generic.IList<string>? state = default,
            bool? responseReceived = default,
            global::System.Collections.Generic.IList<string>? respondedByUserId = default,
            global::System.Collections.Generic.IList<string>? respondedByUserName = default,
            string? subjectSearch = default,
            string? bodySearch = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Hitl Details<br/>
        /// Get Human-in-the-loop details.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `ti_id, subject, responded_at, created_at, responded_by_user_id, responded_by_user_name, dag_id, run_id, run_after, rendered_map_index, task_instance_operator, task_instance_state`<br/>
        /// Default Value: [ti_id]
        /// </param>
        /// <param name="dagIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="taskId"></param>
        /// <param name="taskIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="mapIndex"></param>
        /// <param name="state"></param>
        /// <param name="responseReceived"></param>
        /// <param name="respondedByUserId"></param>
        /// <param name="respondedByUserName"></param>
        /// <param name="subjectSearch">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="bodySearch">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="createdAtGte"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLte"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.HITLDetailCollection>> GetHitlDetailsAsResponseAsync(
            string dagId,
            string dagRunId,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            string? dagIdPattern = default,
            string? taskId = default,
            string? taskIdPattern = default,
            int? mapIndex = default,
            global::System.Collections.Generic.IList<string>? state = default,
            bool? responseReceived = default,
            global::System.Collections.Generic.IList<string>? respondedByUserId = default,
            global::System.Collections.Generic.IList<string>? respondedByUserName = default,
            string? subjectSearch = default,
            string? bodySearch = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}