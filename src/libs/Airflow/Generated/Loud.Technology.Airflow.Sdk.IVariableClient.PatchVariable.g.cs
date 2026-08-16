#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial interface IVariableClient
    {
        /// <summary>
        /// Patch Variable<br/>
        /// Update a variable by key.
        /// </summary>
        /// <param name="variableKey"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.VariableResponse> PatchVariableAsync(
            string variableKey,

            global::Loud.Technology.Airflow.Sdk.VariableBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Variable<br/>
        /// Update a variable by key.
        /// </summary>
        /// <param name="variableKey"></param>
        /// <param name="updateMask"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.VariableResponse>> PatchVariableAsResponseAsync(
            string variableKey,

            global::Loud.Technology.Airflow.Sdk.VariableBody request,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Variable<br/>
        /// Update a variable by key.
        /// </summary>
        /// <param name="variableKey"></param>
        /// <param name="updateMask"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.VariableResponse> PatchVariableAsync(
            string variableKey,
            string key,
            global::Loud.Technology.Airflow.Sdk.JsonValue value,
            global::System.Collections.Generic.IList<string>? updateMask = default,
            string? description = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}