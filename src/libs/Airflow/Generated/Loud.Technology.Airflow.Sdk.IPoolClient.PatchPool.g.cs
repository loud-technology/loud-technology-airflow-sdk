#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IPoolClient
    {
        /// <summary>
        /// Patch Pool<br/>
        /// Update a Pool.
        /// </summary>
        /// <param name="poolName"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.PoolResponse> PatchPoolAsync(
            string poolName,

            global::Loud.Technology.Airflow.Sdk.PoolPatchBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Pool<br/>
        /// Update a Pool.
        /// </summary>
        /// <param name="poolName"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.PoolResponse>> PatchPoolAsResponseAsync(
            string poolName,

            global::Loud.Technology.Airflow.Sdk.PoolPatchBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Pool<br/>
        /// Update a Pool.
        /// </summary>
        /// <param name="poolName"></param>
        /// <param name="updateMask"></param>
        /// <param name="pool"></param>
        /// <param name="slots"></param>
        /// <param name="description"></param>
        /// <param name="includeDeferred"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.PoolResponse> PatchPoolAsync(
            string poolName,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            string? pool = default,
            int? slots = default,
            string? description = default,
            bool? includeDeferred = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}