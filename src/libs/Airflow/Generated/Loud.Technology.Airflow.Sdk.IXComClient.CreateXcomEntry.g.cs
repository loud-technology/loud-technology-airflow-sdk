#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IXComClient
    {
        /// <summary>
        /// Create Xcom Entry<br/>
        /// Create an XCom entry.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="taskId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.XComResponseNative> CreateXcomEntryAsync(
            string dagId,
            string taskId,
            string dagRunId,

            global::Loud.Technology.Airflow.Sdk.XComCreateBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Xcom Entry<br/>
        /// Create an XCom entry.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="taskId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.XComResponseNative>> CreateXcomEntryAsResponseAsync(
            string dagId,
            string taskId,
            string dagRunId,

            global::Loud.Technology.Airflow.Sdk.XComCreateBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Xcom Entry<br/>
        /// Create an XCom entry.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="taskId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="mapIndex">
        /// Default Value: -1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.XComResponseNative> CreateXcomEntryAsync(
            string dagId,
            string taskId,
            string dagRunId,
            string key,
            object value,
            int? mapIndex = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}