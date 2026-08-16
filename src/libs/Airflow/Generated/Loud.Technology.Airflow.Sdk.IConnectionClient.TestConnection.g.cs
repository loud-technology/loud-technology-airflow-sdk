#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IConnectionClient
    {
        /// <summary>
        /// Test Connection<br/>
        /// Test an API connection.<br/>
        /// This method first creates an in-memory transient conn_id &amp; exports that to an env var,<br/>
        /// as some hook classes tries to find out the `conn` from their __init__ method &amp; errors out if not found.<br/>
        /// It also deletes the conn id env connection after the test.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.ConnectionTestResponse> TestConnectionAsync(

            global::Loud.Technology.Airflow.Sdk.ConnectionBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Connection<br/>
        /// Test an API connection.<br/>
        /// This method first creates an in-memory transient conn_id &amp; exports that to an env var,<br/>
        /// as some hook classes tries to find out the `conn` from their __init__ method &amp; errors out if not found.<br/>
        /// It also deletes the conn id env connection after the test.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.ConnectionTestResponse>> TestConnectionAsResponseAsync(

            global::Loud.Technology.Airflow.Sdk.ConnectionBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Connection<br/>
        /// Test an API connection.<br/>
        /// This method first creates an in-memory transient conn_id &amp; exports that to an env var,<br/>
        /// as some hook classes tries to find out the `conn` from their __init__ method &amp; errors out if not found.<br/>
        /// It also deletes the conn id env connection after the test.
        /// </summary>
        /// <param name="connectionId"></param>
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
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.ConnectionTestResponse> TestConnectionAsync(
            string connectionId,
            string connType,
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