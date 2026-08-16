#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IBackfillClient
    {
        /// <summary>
        /// Create Backfill
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.BackfillResponse> CreateBackfillAsync(

            global::Loud.Technology.Airflow.Sdk.BackfillPostBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Backfill
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.BackfillResponse>> CreateBackfillAsResponseAsync(

            global::Loud.Technology.Airflow.Sdk.BackfillPostBody request,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Backfill
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="fromDate"></param>
        /// <param name="toDate"></param>
        /// <param name="runBackwards">
        /// Default Value: false
        /// </param>
        /// <param name="dagRunConf">
        /// Default Value: {}
        /// </param>
        /// <param name="reprocessBehavior">
        /// Internal enum for setting reprocess behavior in a backfill.<br/>
        /// :meta private:<br/>
        /// Default Value: none
        /// </param>
        /// <param name="maxActiveRuns">
        /// Default Value: 10
        /// </param>
        /// <param name="runOnLatestVersion">
        /// Default Value: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.BackfillResponse> CreateBackfillAsync(
            string dagId,
            global::System.DateTime fromDate,
            global::System.DateTime toDate,
            bool? runBackwards = default,
            object? dagRunConf = default,
            global::Loud.Technology.Airflow.Sdk.ReprocessBehavior? reprocessBehavior = default,
            int? maxActiveRuns = default,
            bool? runOnLatestVersion = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}