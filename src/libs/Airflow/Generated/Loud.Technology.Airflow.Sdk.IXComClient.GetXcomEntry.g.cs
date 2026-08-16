#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IXComClient
    {
        /// <summary>
        /// Get Xcom Entry<br/>
        /// Get an XCom entry.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="taskId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="xcomKey"></param>
        /// <param name="mapIndex">
        /// Default Value: -1
        /// </param>
        /// <param name="deserialize">
        /// Default Value: false
        /// </param>
        /// <param name="stringify">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AnyOf<global::Loud.Technology.Airflow.Sdk.XComResponseNative, global::Loud.Technology.Airflow.Sdk.XComResponseString>> GetXcomEntryAsync(
            string dagId,
            string taskId,
            string dagRunId,
            string xcomKey,
            int? mapIndex = default,
            bool? deserialize = default,
            bool? stringify = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Xcom Entry<br/>
        /// Get an XCom entry.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="taskId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="xcomKey"></param>
        /// <param name="mapIndex">
        /// Default Value: -1
        /// </param>
        /// <param name="deserialize">
        /// Default Value: false
        /// </param>
        /// <param name="stringify">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.AnyOf<global::Loud.Technology.Airflow.Sdk.XComResponseNative, global::Loud.Technology.Airflow.Sdk.XComResponseString>>> GetXcomEntryAsResponseAsync(
            string dagId,
            string taskId,
            string dagRunId,
            string xcomKey,
            int? mapIndex = default,
            bool? deserialize = default,
            bool? stringify = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}