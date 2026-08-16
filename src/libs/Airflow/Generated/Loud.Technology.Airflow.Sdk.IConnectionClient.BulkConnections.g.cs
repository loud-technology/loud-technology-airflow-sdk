#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IConnectionClient
    {
        /// <summary>
        /// Bulk Connections<br/>
        /// Bulk create, update, and delete connections.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.BulkResponse> BulkConnectionsAsync(

            global::Loud.Technology.Airflow.Sdk.BulkBodyConnectionBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Connections<br/>
        /// Bulk create, update, and delete connections.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.BulkResponse>> BulkConnectionsAsResponseAsync(

            global::Loud.Technology.Airflow.Sdk.BulkBodyConnectionBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Connections<br/>
        /// Bulk create, update, and delete connections.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.BulkResponse> BulkConnectionsAsync(
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionConnectionBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionConnectionBody>> actions,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}