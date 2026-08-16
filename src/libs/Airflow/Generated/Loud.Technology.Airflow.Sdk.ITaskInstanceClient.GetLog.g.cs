#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface ITaskInstanceClient
    {
        /// <summary>
        /// Get Log<br/>
        /// Get logs for a specific task instance.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="tryNumber"></param>
        /// <param name="fullContent">
        /// Default Value: false
        /// </param>
        /// <param name="mapIndex">
        /// Default Value: -1
        /// </param>
        /// <param name="token"></param>
        /// <param name="accept">
        /// Default Value: */*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.TaskInstancesLogResponse> GetLogAsync(
            string dagId,
            string dagRunId,
            string taskId,
            int tryNumber,
            bool? fullContent = default,
            int? mapIndex = default,
            string? token = default,
            global::Loud.Technology.Airflow.Sdk.GetLogAccept? accept = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Log<br/>
        /// Get logs for a specific task instance.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="tryNumber"></param>
        /// <param name="fullContent">
        /// Default Value: false
        /// </param>
        /// <param name="mapIndex">
        /// Default Value: -1
        /// </param>
        /// <param name="token"></param>
        /// <param name="accept">
        /// Default Value: */*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.TaskInstancesLogResponse>> GetLogAsResponseAsync(
            string dagId,
            string dagRunId,
            string taskId,
            int tryNumber,
            bool? fullContent = default,
            int? mapIndex = default,
            string? token = default,
            global::Loud.Technology.Airflow.Sdk.GetLogAccept? accept = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}