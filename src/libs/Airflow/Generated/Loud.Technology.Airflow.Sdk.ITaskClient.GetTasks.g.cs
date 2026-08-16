#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface ITaskClient
    {
        /// <summary>
        /// Get Tasks<br/>
        /// Get tasks for DAG.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="orderBy">
        /// Default Value: task_id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.TaskCollectionResponse> GetTasksAsync(
            string dagId,
            string? orderBy = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Tasks<br/>
        /// Get tasks for DAG.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="orderBy">
        /// Default Value: task_id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.TaskCollectionResponse>> GetTasksAsResponseAsync(
            string dagId,
            string? orderBy = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}