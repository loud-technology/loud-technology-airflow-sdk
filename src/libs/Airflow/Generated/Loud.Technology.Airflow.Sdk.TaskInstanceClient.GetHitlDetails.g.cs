
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial class TaskInstanceClient
    {


        private static readonly global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement s_GetHitlDetailsSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement[] s_GetHitlDetailsSecurityRequirements =
            new global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement[]
            {                s_GetHitlDetailsSecurityRequirement0,
            };
        partial void PrepareGetHitlDetailsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string dagId,
            ref string dagRunId,
            ref int? limit,
            ref int? offset,
            global::System.Collections.Generic.IList<string>? orderBy,
            ref string? dagIdPattern,
            ref string? taskId,
            ref string? taskIdPattern,
            int? mapIndex,
            global::System.Collections.Generic.IList<string>? state,
            bool? responseReceived,
            global::System.Collections.Generic.IList<string>? respondedByUserId,
            global::System.Collections.Generic.IList<string>? respondedByUserName,
            ref string? subjectSearch,
            ref string? bodySearch,
            global::System.DateTime? createdAtGte,
            global::System.DateTime? createdAtGt,
            global::System.DateTime? createdAtLte,
            global::System.DateTime? createdAtLt);
        partial void PrepareGetHitlDetailsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string dagId,
            string dagRunId,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<string>? orderBy,
            string? dagIdPattern,
            string? taskId,
            string? taskIdPattern,
            int? mapIndex,
            global::System.Collections.Generic.IList<string>? state,
            bool? responseReceived,
            global::System.Collections.Generic.IList<string>? respondedByUserId,
            global::System.Collections.Generic.IList<string>? respondedByUserName,
            string? subjectSearch,
            string? bodySearch,
            global::System.DateTime? createdAtGte,
            global::System.DateTime? createdAtGt,
            global::System.DateTime? createdAtLte,
            global::System.DateTime? createdAtLt);
        partial void ProcessGetHitlDetailsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetHitlDetailsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Hitl Details<br/>
        /// Get Human-in-the-loop details.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `ti_id, subject, responded_at, created_at, responded_by_user_id, responded_by_user_name, dag_id, run_id, run_after, rendered_map_index, task_instance_operator, task_instance_state`<br/>
        /// Default Value: [ti_id]
        /// </param>
        /// <param name="dagIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="taskId"></param>
        /// <param name="taskIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="mapIndex"></param>
        /// <param name="state"></param>
        /// <param name="responseReceived"></param>
        /// <param name="respondedByUserId"></param>
        /// <param name="respondedByUserName"></param>
        /// <param name="subjectSearch">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="bodySearch">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="createdAtGte"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLte"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.HITLDetailCollection> GetHitlDetailsAsync(
            string dagId,
            string dagRunId,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            string? dagIdPattern = default,
            string? taskId = default,
            string? taskIdPattern = default,
            int? mapIndex = default,
            global::System.Collections.Generic.IList<string>? state = default,
            bool? responseReceived = default,
            global::System.Collections.Generic.IList<string>? respondedByUserId = default,
            global::System.Collections.Generic.IList<string>? respondedByUserName = default,
            string? subjectSearch = default,
            string? bodySearch = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetHitlDetailsAsResponseAsync(
                dagId: dagId,
                dagRunId: dagRunId,
                limit: limit,
                offset: offset,
                orderBy: orderBy,
                dagIdPattern: dagIdPattern,
                taskId: taskId,
                taskIdPattern: taskIdPattern,
                mapIndex: mapIndex,
                state: state,
                responseReceived: responseReceived,
                respondedByUserId: respondedByUserId,
                respondedByUserName: respondedByUserName,
                subjectSearch: subjectSearch,
                bodySearch: bodySearch,
                createdAtGte: createdAtGte,
                createdAtGt: createdAtGt,
                createdAtLte: createdAtLte,
                createdAtLt: createdAtLt,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Hitl Details<br/>
        /// Get Human-in-the-loop details.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="dagRunId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `ti_id, subject, responded_at, created_at, responded_by_user_id, responded_by_user_name, dag_id, run_id, run_after, rendered_map_index, task_instance_operator, task_instance_state`<br/>
        /// Default Value: [ti_id]
        /// </param>
        /// <param name="dagIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="taskId"></param>
        /// <param name="taskIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="mapIndex"></param>
        /// <param name="state"></param>
        /// <param name="responseReceived"></param>
        /// <param name="respondedByUserId"></param>
        /// <param name="respondedByUserName"></param>
        /// <param name="subjectSearch">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="bodySearch">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="createdAtGte"></param>
        /// <param name="createdAtGt"></param>
        /// <param name="createdAtLte"></param>
        /// <param name="createdAtLt"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.HITLDetailCollection>> GetHitlDetailsAsResponseAsync(
            string dagId,
            string dagRunId,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            string? dagIdPattern = default,
            string? taskId = default,
            string? taskIdPattern = default,
            int? mapIndex = default,
            global::System.Collections.Generic.IList<string>? state = default,
            bool? responseReceived = default,
            global::System.Collections.Generic.IList<string>? respondedByUserId = default,
            global::System.Collections.Generic.IList<string>? respondedByUserName = default,
            string? subjectSearch = default,
            string? bodySearch = default,
            global::System.DateTime? createdAtGte = default,
            global::System.DateTime? createdAtGt = default,
            global::System.DateTime? createdAtLte = default,
            global::System.DateTime? createdAtLt = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetHitlDetailsArguments(
                httpClient: HttpClient,
                dagId: ref dagId,
                dagRunId: ref dagRunId,
                limit: ref limit,
                offset: ref offset,
                orderBy: orderBy,
                dagIdPattern: ref dagIdPattern,
                taskId: ref taskId,
                taskIdPattern: ref taskIdPattern,
                mapIndex: mapIndex,
                state: state,
                responseReceived: responseReceived,
                respondedByUserId: respondedByUserId,
                respondedByUserName: respondedByUserName,
                subjectSearch: ref subjectSearch,
                bodySearch: ref bodySearch,
                createdAtGte: createdAtGte,
                createdAtGt: createdAtGt,
                createdAtLte: createdAtLte,
                createdAtLt: createdAtLt);


            var __authorizations = global::Loud.Technology.Airflow.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetHitlDetailsSecurityRequirements,
                operationName: "GetHitlDetailsAsync");

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
                                path: $"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/hitlDetails",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("order_by", orderBy, delimiter: ",", explode: true)
                                .AddOptionalParameter("dag_id_pattern", dagIdPattern)
                                .AddOptionalParameter("task_id", taskId)
                                .AddOptionalParameter("task_id_pattern", taskIdPattern)
                                .AddOptionalParameter("map_index", mapIndex?.ToString())
                                .AddOptionalParameter("state", state, delimiter: ",", explode: true)
                                .AddOptionalParameter("response_received", responseReceived?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("responded_by_user_id", respondedByUserId, delimiter: ",", explode: true)
                                .AddOptionalParameter("responded_by_user_name", respondedByUserName, delimiter: ",", explode: true)
                                .AddOptionalParameter("subject_search", subjectSearch)
                                .AddOptionalParameter("body_search", bodySearch)
                                .AddOptionalParameter("created_at_gte", createdAtGte?.ToString())
                                .AddOptionalParameter("created_at_gt", createdAtGt?.ToString())
                                .AddOptionalParameter("created_at_lte", createdAtLte?.ToString())
                                .AddOptionalParameter("created_at_lt", createdAtLt?.ToString())
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
                global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetHitlDetailsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    dagId: dagId!,
                    dagRunId: dagRunId!,
                    limit: limit,
                    offset: offset,
                    orderBy: orderBy,
                    dagIdPattern: dagIdPattern,
                    taskId: taskId,
                    taskIdPattern: taskIdPattern,
                    mapIndex: mapIndex,
                    state: state,
                    responseReceived: responseReceived,
                    respondedByUserId: respondedByUserId,
                    respondedByUserName: respondedByUserName,
                    subjectSearch: subjectSearch,
                    bodySearch: bodySearch,
                    createdAtGte: createdAtGte,
                    createdAtGt: createdAtGt,
                    createdAtLte: createdAtLte,
                    createdAtLt: createdAtLt);

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
                                operationId: "GetHitlDetails",
                                methodName: "GetHitlDetailsAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/hitlDetails\"",
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
                                operationId: "GetHitlDetails",
                                methodName: "GetHitlDetailsAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/hitlDetails\"",
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
                                operationId: "GetHitlDetails",
                                methodName: "GetHitlDetailsAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/hitlDetails\"",
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
                ProcessGetHitlDetailsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetHitlDetails",
                                methodName: "GetHitlDetailsAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/hitlDetails\"",
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
                                operationId: "GetHitlDetails",
                                methodName: "GetHitlDetailsAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns/{dagRunId}/hitlDetails\"",
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
                                ProcessGetHitlDetailsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.Airflow.Sdk.HITLDetailCollection.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.HITLDetailCollection>(
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

                                    var __value = await global::Loud.Technology.Airflow.Sdk.HITLDetailCollection.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.HITLDetailCollection>(
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
    }
}