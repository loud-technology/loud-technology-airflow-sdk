#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IJobClient
    {
        /// <summary>
        /// Get Jobs<br/>
        /// Get all jobs.
        /// </summary>
        /// <param name="isAlive"></param>
        /// <param name="startDateGte"></param>
        /// <param name="startDateGt"></param>
        /// <param name="startDateLte"></param>
        /// <param name="startDateLt"></param>
        /// <param name="endDateGte"></param>
        /// <param name="endDateGt"></param>
        /// <param name="endDateLte"></param>
        /// <param name="endDateLt"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, dag_id, state, job_type, start_date, end_date, latest_heartbeat, executor_class, hostname, unixname`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="jobState"></param>
        /// <param name="jobType"></param>
        /// <param name="hostname"></param>
        /// <param name="executorClass"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.JobCollectionResponse> GetJobsAsync(
            bool? isAlive = default,
            global::System.DateTime? startDateGte = default,
            global::System.DateTime? startDateGt = default,
            global::System.DateTime? startDateLte = default,
            global::System.DateTime? startDateLt = default,
            global::System.DateTime? endDateGte = default,
            global::System.DateTime? endDateGt = default,
            global::System.DateTime? endDateLte = default,
            global::System.DateTime? endDateLt = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            string? jobState = default,
            string? jobType = default,
            string? hostname = default,
            string? executorClass = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Jobs<br/>
        /// Get all jobs.
        /// </summary>
        /// <param name="isAlive"></param>
        /// <param name="startDateGte"></param>
        /// <param name="startDateGt"></param>
        /// <param name="startDateLte"></param>
        /// <param name="startDateLt"></param>
        /// <param name="endDateGte"></param>
        /// <param name="endDateGt"></param>
        /// <param name="endDateLte"></param>
        /// <param name="endDateLt"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, dag_id, state, job_type, start_date, end_date, latest_heartbeat, executor_class, hostname, unixname`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="jobState"></param>
        /// <param name="jobType"></param>
        /// <param name="hostname"></param>
        /// <param name="executorClass"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.JobCollectionResponse>> GetJobsAsResponseAsync(
            bool? isAlive = default,
            global::System.DateTime? startDateGte = default,
            global::System.DateTime? startDateGt = default,
            global::System.DateTime? startDateLte = default,
            global::System.DateTime? startDateLt = default,
            global::System.DateTime? endDateGte = default,
            global::System.DateTime? endDateGt = default,
            global::System.DateTime? endDateLte = default,
            global::System.DateTime? endDateLt = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            string? jobState = default,
            string? jobType = default,
            string? hostname = default,
            string? executorClass = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}