#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IConfigClient
    {
        /// <summary>
        /// Get Config Value
        /// </summary>
        /// <param name="section"></param>
        /// <param name="option"></param>
        /// <param name="accept">
        /// Default Value: */*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.Config> GetConfigValueAsync(
            string section,
            string option,
            global::Loud.Technology.Airflow.Sdk.GetConfigValueAccept? accept = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Config Value
        /// </summary>
        /// <param name="section"></param>
        /// <param name="option"></param>
        /// <param name="accept">
        /// Default Value: */*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.Config>> GetConfigValueAsResponseAsync(
            string section,
            string option,
            global::Loud.Technology.Airflow.Sdk.GetConfigValueAccept? accept = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}