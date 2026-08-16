
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial class TaskInstanceClient
    {


        private static readonly global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement s_GetLogAsStreamSecurityRequirement0 =
            new global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement
            {
                Authorizations = new global::Loud.Technology.Airflow.Sdk.EndPointAuthorizationRequirement[]
                {                    new global::Loud.Technology.Airflow.Sdk.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement[] s_GetLogAsStreamSecurityRequirements =
            new global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement[]
            {                s_GetLogAsStreamSecurityRequirement0,
            };
        partial void PrepareGetLogAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string dagId,
            ref string dagRunId,
            ref string taskId,
            ref int tryNumber,
            ref bool? fullContent,
            ref int? mapIndex,
            ref string? token,
            ref global::Loud.Technology.Airflow.Sdk.GetLogAccept? accept);
        partial void PrepareGetLogAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string dagId,
            string dagRunId,
            string taskId,
            int tryNumber,
            bool? fullContent,
            int? mapIndex,
            string? token,
            global::Loud.Technology.Airflow.Sdk.GetLogAccept? accept);
        partial void ProcessGetLogAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Get Log<br/>
        /// Get logs for a specific task instance.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="taskId"></param>
        /// <param name="tryNumber"></param>
        /// <param name="fullContent">
        /// Default Value: false
        /// </param>
        /// <param name="mapIndex">
        /// Default Value: -1
        /// </param>
        /// <param name="token"></param>
        /// <param name="accept">
        /// Default Value: */*
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<string> GetLogAsStreamAsync(
            string dagId,
            string dagRunId,
            string taskId,
            int tryNumber,
            bool? fullContent = default,
            int? mapIndex = default,
            string? token = default,
            global::Loud.Technology.Airflow.Sdk.GetLogAccept? accept = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetLogAsStreamArguments(
                httpClient: HttpClient,
                dagId: ref dagId,
                dagRunId: ref dagRunId,
                taskId: ref taskId,
                tryNumber: ref tryNumber,
                fullContent: ref fullContent,
                mapIndex: ref mapIndex,
                token: ref token,
                accept: ref accept);


            var __authorizations = global::Loud.Technology.Airflow.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetLogAsStreamSecurityRequirements,
                operationName: "GetLogAsStreamAsync");

            using var __timeoutCancellationTokenSource = global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Loud.Technology.Airflow.Sdk.PathBuilder(
                                path: $"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/taskInstances/{taskId}/logs/{tryNumber}",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("full_content", fullContent?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("map_index", mapIndex?.ToString())
                                .AddOptionalParameter("token", token)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

            if (accept != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("accept", accept?.ToValueString() ?? string.Empty);
            }

                global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetLogAsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    dagId: dagId!,
                    dagRunId: dagRunId!,
                    taskId: taskId!,
                    tryNumber: tryNumber!,
                    fullContent: fullContent,
                    mapIndex: mapIndex,
                    token: token,
                    accept: accept);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetLogAsStream",
                                methodName: "GetLogAsStreamAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/taskInstances/{taskId}/logs/{tryNumber}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetLogAsStream",
                                methodName: "GetLogAsStreamAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/taskInstances/{taskId}/logs/{tryNumber}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetLogAsStream",
                                methodName: "GetLogAsStreamAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/taskInstances/{taskId}/logs/{tryNumber}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetLogAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetLogAsStream",
                                methodName: "GetLogAsStreamAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/taskInstances/{taskId}/logs/{tryNumber}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetLogAsStream",
                                methodName: "GetLogAsStreamAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/taskInstances/{taskId}/logs/{tryNumber}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);
                                }
                                catch (global::System.Exception)
                                {
                                }

                                throw global::Loud.Technology.Airflow.Sdk.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            using var __reader = new global::System.IO.StreamReader(__stream);

                            while (!__reader.EndOfStream && !__effectiveCancellationToken.IsCancellationRequested)
                            {
                                var __content = await __reader.ReadLineAsync().ConfigureAwait(false) ?? string.Empty;
                                if (global::System.String.IsNullOrWhiteSpace(__content))
                                {
                                    continue;
                                }

                                var __streamedResponse = (string?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(string), JsonSerializerContext) ??
                                                       throw global::Loud.Technology.Airflow.Sdk.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}