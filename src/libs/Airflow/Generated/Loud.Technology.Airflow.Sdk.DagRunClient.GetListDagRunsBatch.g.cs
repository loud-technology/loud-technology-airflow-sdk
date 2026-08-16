
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial class DagRunClient
    {


        private static readonly global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement s_GetListDagRunsBatchSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement[] s_GetListDagRunsBatchSecurityRequirements =
            new global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement[]
            {                s_GetListDagRunsBatchSecurityRequirement0,
            };
        partial void PrepareGetListDagRunsBatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string dagId,
            global::Loud.Technology.Airflow.Sdk.DAGRunsBatchBody request);
        partial void PrepareGetListDagRunsBatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string dagId,
            global::Loud.Technology.Airflow.Sdk.DAGRunsBatchBody request);
        partial void ProcessGetListDagRunsBatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetListDagRunsBatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get List Dag Runs Batch<br/>
        /// Get a list of DAG Runs.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGRunCollectionResponse> GetListDagRunsBatchAsync(

            global::Loud.Technology.Airflow.Sdk.DAGRunsBatchBody request,
            string dagId = "~",
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetListDagRunsBatchAsResponseAsync(

                request: request,
                dagId: dagId,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get List Dag Runs Batch<br/>
        /// Get a list of DAG Runs.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGRunCollectionResponse>> GetListDagRunsBatchAsResponseAsync(

            global::Loud.Technology.Airflow.Sdk.DAGRunsBatchBody request,
            string dagId = "~",
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGetListDagRunsBatchArguments(
                httpClient: HttpClient,
                dagId: ref dagId,
                request: request);


            var __authorizations = global::Loud.Technology.Airflow.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetListDagRunsBatchSecurityRequirements,
                operationName: "GetListDagRunsBatchAsync");

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
                                path: $"/api/v2/dags/{dagId}/dagRuns/list",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
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
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetListDagRunsBatchRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    dagId: dagId!,
                    request: request);

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
                                operationId: "GetListDagRunsBatch",
                                methodName: "GetListDagRunsBatchAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/list\"",
                                httpMethod: "POST",
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
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
                                operationId: "GetListDagRunsBatch",
                                methodName: "GetListDagRunsBatchAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/list\"",
                                httpMethod: "POST",
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
                                operationId: "GetListDagRunsBatch",
                                methodName: "GetListDagRunsBatchAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/list\"",
                                httpMethod: "POST",
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
                ProcessGetListDagRunsBatchResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetListDagRunsBatch",
                                methodName: "GetListDagRunsBatchAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/list\"",
                                httpMethod: "POST",
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
                                operationId: "GetListDagRunsBatch",
                                methodName: "GetListDagRunsBatchAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/list\"",
                                httpMethod: "POST",
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
                            // Unauthorized
                            if ((int)__response.StatusCode == 401)
                            {
                                string? __content_401 = null;
                                global::System.Exception? __exception_401 = null;
                                global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse? __value_401 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_401 = global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_401 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_401 = global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse.FromJson(__content_401, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_401 = __ex;
                                }


                                throw global::Loud.Technology.Airflow.Sdk.ApiException<global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_401,
                                    responseBody: __content_401,
                                    responseObject: __value_401,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Forbidden
                            if ((int)__response.StatusCode == 403)
                            {
                                string? __content_403 = null;
                                global::System.Exception? __exception_403 = null;
                                global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse? __value_403 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_403 = global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_403 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_403 = global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse.FromJson(__content_403, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_403 = __ex;
                                }


                                throw global::Loud.Technology.Airflow.Sdk.ApiException<global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_403,
                                    responseBody: __content_403,
                                    responseObject: __value_403,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Not Found
                            if ((int)__response.StatusCode == 404)
                            {
                                string? __content_404 = null;
                                global::System.Exception? __exception_404 = null;
                                global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse? __value_404 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_404 = global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_404 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_404 = global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse.FromJson(__content_404, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_404 = __ex;
                                }


                                throw global::Loud.Technology.Airflow.Sdk.ApiException<global::Loud.Technology.Airflow.Sdk.HTTPExceptionResponse>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_404,
                                    responseBody: __content_404,
                                    responseObject: __value_404,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Loud.Technology.Airflow.Sdk.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Loud.Technology.Airflow.Sdk.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Loud.Technology.Airflow.Sdk.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }


                                throw global::Loud.Technology.Airflow.Sdk.ApiException<global::Loud.Technology.Airflow.Sdk.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetListDagRunsBatchResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.Airflow.Sdk.DAGRunCollectionResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGRunCollectionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
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
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Loud.Technology.Airflow.Sdk.DAGRunCollectionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGRunCollectionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
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
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Get List Dag Runs Batch<br/>
        /// Get a list of DAG Runs.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="orderBy"></param>
        /// <param name="pageOffset">
        /// Default Value: 0
        /// </param>
        /// <param name="pageLimit">
        /// Default Value: 100
        /// </param>
        /// <param name="dagIds"></param>
        /// <param name="states"></param>
        /// <param name="runAfterGte"></param>
        /// <param name="runAfterGt"></param>
        /// <param name="runAfterLte"></param>
        /// <param name="runAfterLt"></param>
        /// <param name="logicalDateGte"></param>
        /// <param name="logicalDateGt"></param>
        /// <param name="logicalDateLte"></param>
        /// <param name="logicalDateLt"></param>
        /// <param name="startDateGte"></param>
        /// <param name="startDateGt"></param>
        /// <param name="startDateLte"></param>
        /// <param name="startDateLt"></param>
        /// <param name="endDateGte"></param>
        /// <param name="endDateGt"></param>
        /// <param name="endDateLte"></param>
        /// <param name="endDateLt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGRunCollectionResponse> GetListDagRunsBatchAsync(
            string dagId = "~",
            string? orderBy = default,
            int? pageOffset = default,
            int? pageLimit = default,
            global::System.Collections.Generic.IList<string>? dagIds = default,
            global::System.Collections.Generic.IList<global::Loud.Technology.Airflow.Sdk.DagRunState>? states = default,
            global::System.DateTime? runAfterGte = default,
            global::System.DateTime? runAfterGt = default,
            global::System.DateTime? runAfterLte = default,
            global::System.DateTime? runAfterLt = default,
            global::System.DateTime? logicalDateGte = default,
            global::System.DateTime? logicalDateGt = default,
            global::System.DateTime? logicalDateLte = default,
            global::System.DateTime? logicalDateLt = default,
            global::System.DateTime? startDateGte = default,
            global::System.DateTime? startDateGt = default,
            global::System.DateTime? startDateLte = default,
            global::System.DateTime? startDateLt = default,
            global::System.DateTime? endDateGte = default,
            global::System.DateTime? endDateGt = default,
            global::System.DateTime? endDateLte = default,
            global::System.DateTime? endDateLt = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loud.Technology.Airflow.Sdk.DAGRunsBatchBody
            {
                OrderBy = orderBy,
                PageOffset = pageOffset,
                PageLimit = pageLimit,
                DagIds = dagIds,
                States = states,
                RunAfterGte = runAfterGte,
                RunAfterGt = runAfterGt,
                RunAfterLte = runAfterLte,
                RunAfterLt = runAfterLt,
                LogicalDateGte = logicalDateGte,
                LogicalDateGt = logicalDateGt,
                LogicalDateLte = logicalDateLte,
                LogicalDateLt = logicalDateLt,
                StartDateGte = startDateGte,
                StartDateGt = startDateGt,
                StartDateLte = startDateLte,
                StartDateLt = startDateLt,
                EndDateGte = endDateGte,
                EndDateGt = endDateGt,
                EndDateLte = endDateLte,
                EndDateLt = endDateLt,
            };

            return await GetListDagRunsBatchAsync(
                dagId: dagId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}