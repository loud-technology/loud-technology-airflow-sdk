#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface ITaskInstanceClient
    {
        /// <summary>
        /// Bulk Task Instances<br/>
        /// Bulk update, and delete task instances.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.BulkResponse> BulkTaskInstancesAsync(
            string dagId,
            string dagRunId,

            global::Loud.Technology.Airflow.Sdk.BulkBodyBulkTaskInstanceBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Task Instances<br/>
        /// Bulk update, and delete task instances.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.BulkResponse>> BulkTaskInstancesAsResponseAsync(
            string dagId,
            string dagRunId,

            global::Loud.Technology.Airflow.Sdk.BulkBodyBulkTaskInstanceBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk Task Instances<br/>
        /// Bulk update, and delete task instances.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="actions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.BulkResponse> BulkTaskInstancesAsync(
            string dagId,
            string dagRunId,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.OneOf<global::Loud.Technology.Airflow.Sdk.BulkCreateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkUpdateActionBulkTaskInstanceBody, global::Loud.Technology.Airflow.Sdk.BulkDeleteActionBulkTaskInstanceBody>> actions,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}