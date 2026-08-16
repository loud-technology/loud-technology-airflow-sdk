#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagSourceClient
    {
        /// <summary>
        /// Get Dag Source<br/>
        /// Get source code using file token.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="versionNumber"></param>
        /// <param name="accept">
        /// Default Value: */*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGSourceResponse> GetDagSourceAsync(
            string dagId,
            int? versionNumber = default,
            global::Loud.Technology.Airflow.Sdk.GetDagSourceAccept? accept = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Dag Source<br/>
        /// Get source code using file token.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="versionNumber"></param>
        /// <param name="accept">
        /// Default Value: */*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGSourceResponse>> GetDagSourceAsResponseAsync(
            string dagId,
            int? versionNumber = default,
            global::Loud.Technology.Airflow.Sdk.GetDagSourceAccept? accept = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}