#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IEventLogClient
    {
        /// <summary>
        /// Get Event Logs<br/>
        /// Get all Event Logs.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, dttm, dag_id, task_id, run_id, event, logical_date, owner, extra, when, event_log_id`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="dagId"></param>
        /// <param name="taskId"></param>
        /// <param name="runId"></param>
        /// <param name="mapIndex"></param>
        /// <param name="tryNumber"></param>
        /// <param name="owner"></param>
        /// <param name="event"></param>
        /// <param name="excludedEvents"></param>
        /// <param name="includedEvents"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="dagIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="taskIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="runIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="ownerPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="eventPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.EventLogCollectionResponse> GetEventLogsAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            string? dagId = default,
            string? taskId = default,
            string? runId = default,
            int? mapIndex = default,
            int? tryNumber = default,
            string? owner = default,
            string? @event = default,
            global::System.Collections.Generic.IList<string>? excludedEvents = default,
            global::System.Collections.Generic.IList<string>? includedEvents = default,
            global::System.DateTime? before = default,
            global::System.DateTime? after = default,
            string? dagIdPattern = default,
            string? taskIdPattern = default,
            string? runIdPattern = default,
            string? ownerPattern = default,
            string? eventPattern = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Event Logs<br/>
        /// Get all Event Logs.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, dttm, dag_id, task_id, run_id, event, logical_date, owner, extra, when, event_log_id`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="dagId"></param>
        /// <param name="taskId"></param>
        /// <param name="runId"></param>
        /// <param name="mapIndex"></param>
        /// <param name="tryNumber"></param>
        /// <param name="owner"></param>
        /// <param name="event"></param>
        /// <param name="excludedEvents"></param>
        /// <param name="includedEvents"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="dagIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="taskIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="runIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="ownerPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="eventPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.EventLogCollectionResponse>> GetEventLogsAsResponseAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            string? dagId = default,
            string? taskId = default,
            string? runId = default,
            int? mapIndex = default,
            int? tryNumber = default,
            string? owner = default,
            string? @event = default,
            global::System.Collections.Generic.IList<string>? excludedEvents = default,
            global::System.Collections.Generic.IList<string>? includedEvents = default,
            global::System.DateTime? before = default,
            global::System.DateTime? after = default,
            string? dagIdPattern = default,
            string? taskIdPattern = default,
            string? runIdPattern = default,
            string? ownerPattern = default,
            string? eventPattern = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}