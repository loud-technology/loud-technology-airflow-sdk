#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagParsingClient
    {
        /// <summary>
        /// Reparse Dag File<br/>
        /// Request re-parsing a DAG file.
        /// </summary>
        /// <param name="fileToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReparseDagFileAsync(
            string fileToken,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reparse Dag File<br/>
        /// Request re-parsing a DAG file.
        /// </summary>
        /// <param name="fileToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<string>> ReparseDagFileAsResponseAsync(
            string fileToken,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}