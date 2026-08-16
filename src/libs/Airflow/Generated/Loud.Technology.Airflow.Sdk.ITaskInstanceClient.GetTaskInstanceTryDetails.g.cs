#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface ITaskInstanceClient
    {
        /// <summary>
        /// Get Task Instance Try Details<br/>
        /// Get task instance details by try number.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="taskTryNumber"></param>
        /// <param name="mapIndex">
        /// Default Value: -1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.TaskInstanceHistoryResponse> GetTaskInstanceTryDetailsAsync(
            string dagId,
            string dagRunId,
            string taskId,
            int taskTryNumber,
            int? mapIndex = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Task Instance Try Details<br/>
        /// Get task instance details by try number.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="taskTryNumber"></param>
        /// <param name="mapIndex">
        /// Default Value: -1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.TaskInstanceHistoryResponse>> GetTaskInstanceTryDetailsAsResponseAsync(
            string dagId,
            string dagRunId,
            string taskId,
            int taskTryNumber,
            int? mapIndex = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}