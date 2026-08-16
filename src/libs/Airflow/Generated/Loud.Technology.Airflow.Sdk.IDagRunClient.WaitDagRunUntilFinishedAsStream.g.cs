#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IDagRunClient
    {
        /// <summary>
        /// Experimental: Wait for a dag run to complete, and return task results if requested.<br/>
        /// 🚧 This is an experimental endpoint and may change or be removed without notice.Successful response are streamed as newline-delimited JSON (NDJSON). Each line is a JSON object representing the DAG run state.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="interval">
        /// Seconds to wait between dag run state checks
        /// </param>
        /// <param name="result">
        /// Collect result XCom from task. Can be set multiple times.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LOUD_TECHNOLOGY_AIRFLOW_SDK_EXPERIMENTAL_001")]
#endif
        global::System.Collections.Generic.IAsyncEnumerable<string> WaitDagRunUntilFinishedAsStreamAsync(
            string dagId,
            string dagRunId,
            double interval,
            global::System.Collections.Generic.IList<string>? result = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}