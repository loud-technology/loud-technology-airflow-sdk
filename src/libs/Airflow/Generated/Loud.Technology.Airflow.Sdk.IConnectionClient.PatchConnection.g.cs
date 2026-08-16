#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IConnectionClient
    {
        /// <summary>
        /// Patch Connection<br/>
        /// Update a connection entry.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.ConnectionResponse> PatchConnectionAsync(
            string connectionId,

            global::Loud.Technology.Airflow.Sdk.ConnectionBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Connection<br/>
        /// Update a connection entry.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.ConnectionResponse>> PatchConnectionAsResponseAsync(
            string connectionId,

            global::Loud.Technology.Airflow.Sdk.ConnectionBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Connection<br/>
        /// Update a connection entry.
        /// </summary>
        /// <param name="connectionId"></param>
        /// <param name="updateMask"></param>
        /// <param name="requestConnectionId"></param>
        /// <param name="connType"></param>
        /// <param name="description"></param>
        /// <param name="host"></param>
        /// <param name="login"></param>
        /// <param name="schema"></param>
        /// <param name="port"></param>
        /// <param name="password"></param>
        /// <param name="extra"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.ConnectionResponse> PatchConnectionAsync(
            string connectionId,
            string requestConnectionId,
            string connType,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            string? description = default,
            string? host = default,
            string? login = default,
            string? schema = default,
            int? port = default,
            string? password = default,
            string? extra = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}