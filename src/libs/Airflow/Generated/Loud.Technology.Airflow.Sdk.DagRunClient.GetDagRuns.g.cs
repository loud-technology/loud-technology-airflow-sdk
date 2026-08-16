
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial class DagRunClient
    {


        private static readonly global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement s_GetDagRunsSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement[] s_GetDagRunsSecurityRequirements =
            new global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement[]
            {                s_GetDagRunsSecurityRequirement0,
            };
        partial void PrepareGetDagRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string dagId,
            ref int? limit,
            ref int? offset,
            global::System.DateTime? runAfterGte,
            global::System.DateTime? runAfterGt,
            global::System.DateTime? runAfterLte,
            global::System.DateTime? runAfterLt,
            global::System.DateTime? logicalDateGte,
            global::System.DateTime? logicalDateGt,
            global::System.DateTime? logicalDateLte,
            global::System.DateTime? logicalDateLt,
            global::System.DateTime? startDateGte,
            global::System.DateTime? startDateGt,
            global::System.DateTime? startDateLte,
            global::System.DateTime? startDateLt,
            global::System.DateTime? endDateGte,
            global::System.DateTime? endDateGt,
            global::System.DateTime? endDateLte,
            global::System.DateTime? endDateLt,
            global::System.DateTime? updatedAtGte,
            global::System.DateTime? updatedAtGt,
            global::System.DateTime? updatedAtLte,
            global::System.DateTime? updatedAtLt,
            global::System.Collections.Generic.IList<string>? runType,
            global::System.Collections.Generic.IList<string>? state,
            global::System.Collections.Generic.IList<int>? dagVersion,
            global::System.Collections.Generic.IList<string>? orderBy,
            ref string? runIdPattern,
            ref string? triggeringUserNamePattern);
        partial void PrepareGetDagRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string dagId,
            int? limit,
            int? offset,
            global::System.DateTime? runAfterGte,
            global::System.DateTime? runAfterGt,
            global::System.DateTime? runAfterLte,
            global::System.DateTime? runAfterLt,
            global::System.DateTime? logicalDateGte,
            global::System.DateTime? logicalDateGt,
            global::System.DateTime? logicalDateLte,
            global::System.DateTime? logicalDateLt,
            global::System.DateTime? startDateGte,
            global::System.DateTime? startDateGt,
            global::System.DateTime? startDateLte,
            global::System.DateTime? startDateLt,
            global::System.DateTime? endDateGte,
            global::System.DateTime? endDateGt,
            global::System.DateTime? endDateLte,
            global::System.DateTime? endDateLt,
            global::System.DateTime? updatedAtGte,
            global::System.DateTime? updatedAtGt,
            global::System.DateTime? updatedAtLte,
            global::System.DateTime? updatedAtLt,
            global::System.Collections.Generic.IList<string>? runType,
            global::System.Collections.Generic.IList<string>? state,
            global::System.Collections.Generic.IList<int>? dagVersion,
            global::System.Collections.Generic.IList<string>? orderBy,
            string? runIdPattern,
            string? triggeringUserNamePattern);
        partial void ProcessGetDagRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDagRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Dag Runs<br/>
        /// Get all DAG Runs.<br/>
        /// This endpoint allows specifying `~` as the dag_id to retrieve Dag Runs for all DAGs.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
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
        /// <param name="updatedAtGte"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLte"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="runType"></param>
        /// <param name="state"></param>
        /// <param name="dagVersion"></param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, state, dag_id, run_id, logical_date, run_after, start_date, end_date, updated_at, conf, duration, dag_run_id`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="runIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="triggeringUserNamePattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGRunCollectionResponse> GetDagRunsAsync(
            string dagId,
            int? limit = default,
            int? offset = default,
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
            global::System.DateTime? updatedAtGte = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLte = default,
            global::System.DateTime? updatedAtLt = default,
            global::System.Collections.Generic.IList<string>? runType = default,
            global::System.Collections.Generic.IList<string>? state = default,
            global::System.Collections.Generic.IList<int>? dagVersion = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            string? runIdPattern = default,
            string? triggeringUserNamePattern = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetDagRunsAsResponseAsync(
                dagId: dagId,
                limit: limit,
                offset: offset,
                runAfterGte: runAfterGte,
                runAfterGt: runAfterGt,
                runAfterLte: runAfterLte,
                runAfterLt: runAfterLt,
                logicalDateGte: logicalDateGte,
                logicalDateGt: logicalDateGt,
                logicalDateLte: logicalDateLte,
                logicalDateLt: logicalDateLt,
                startDateGte: startDateGte,
                startDateGt: startDateGt,
                startDateLte: startDateLte,
                startDateLt: startDateLt,
                endDateGte: endDateGte,
                endDateGt: endDateGt,
                endDateLte: endDateLte,
                endDateLt: endDateLt,
                updatedAtGte: updatedAtGte,
                updatedAtGt: updatedAtGt,
                updatedAtLte: updatedAtLte,
                updatedAtLt: updatedAtLt,
                runType: runType,
                state: state,
                dagVersion: dagVersion,
                orderBy: orderBy,
                runIdPattern: runIdPattern,
                triggeringUserNamePattern: triggeringUserNamePattern,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Dag Runs<br/>
        /// Get all DAG Runs.<br/>
        /// This endpoint allows specifying `~` as the dag_id to retrieve Dag Runs for all DAGs.
        /// </summary>
        /// <param name="dagId"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
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
        /// <param name="updatedAtGte"></param>
        /// <param name="updatedAtGt"></param>
        /// <param name="updatedAtLte"></param>
        /// <param name="updatedAtLt"></param>
        /// <param name="runType"></param>
        /// <param name="state"></param>
        /// <param name="dagVersion"></param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `id, state, dag_id, run_id, logical_date, run_after, start_date, end_date, updated_at, conf, duration, dag_run_id`<br/>
        /// Default Value: [id]
        /// </param>
        /// <param name="runIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="triggeringUserNamePattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGRunCollectionResponse>> GetDagRunsAsResponseAsync(
            string dagId,
            int? limit = default,
            int? offset = default,
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
            global::System.DateTime? updatedAtGte = default,
            global::System.DateTime? updatedAtGt = default,
            global::System.DateTime? updatedAtLte = default,
            global::System.DateTime? updatedAtLt = default,
            global::System.Collections.Generic.IList<string>? runType = default,
            global::System.Collections.Generic.IList<string>? state = default,
            global::System.Collections.Generic.IList<int>? dagVersion = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            string? runIdPattern = default,
            string? triggeringUserNamePattern = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetDagRunsArguments(
                httpClient: HttpClient,
                dagId: ref dagId,
                limit: ref limit,
                offset: ref offset,
                runAfterGte: runAfterGte,
                runAfterGt: runAfterGt,
                runAfterLte: runAfterLte,
                runAfterLt: runAfterLt,
                logicalDateGte: logicalDateGte,
                logicalDateGt: logicalDateGt,
                logicalDateLte: logicalDateLte,
                logicalDateLt: logicalDateLt,
                startDateGte: startDateGte,
                startDateGt: startDateGt,
                startDateLte: startDateLte,
                startDateLt: startDateLt,
                endDateGte: endDateGte,
                endDateGt: endDateGt,
                endDateLte: endDateLte,
                endDateLt: endDateLt,
                updatedAtGte: updatedAtGte,
                updatedAtGt: updatedAtGt,
                updatedAtLte: updatedAtLte,
                updatedAtLt: updatedAtLt,
                runType: runType,
                state: state,
                dagVersion: dagVersion,
                orderBy: orderBy,
                runIdPattern: ref runIdPattern,
                triggeringUserNamePattern: ref triggeringUserNamePattern);


            var __authorizations = global::Loud.Technology.Airflow.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetDagRunsSecurityRequirements,
                operationName: "GetDagRunsAsync");

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
                                path: $"/api/v2/dags/{dagId}/dagRuns",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("run_after_gte", runAfterGte?.ToString())
                                .AddOptionalParameter("run_after_gt", runAfterGt?.ToString())
                                .AddOptionalParameter("run_after_lte", runAfterLte?.ToString())
                                .AddOptionalParameter("run_after_lt", runAfterLt?.ToString())
                                .AddOptionalParameter("logical_date_gte", logicalDateGte?.ToString())
                                .AddOptionalParameter("logical_date_gt", logicalDateGt?.ToString())
                                .AddOptionalParameter("logical_date_lte", logicalDateLte?.ToString())
                                .AddOptionalParameter("logical_date_lt", logicalDateLt?.ToString())
                                .AddOptionalParameter("start_date_gte", startDateGte?.ToString())
                                .AddOptionalParameter("start_date_gt", startDateGt?.ToString())
                                .AddOptionalParameter("start_date_lte", startDateLte?.ToString())
                                .AddOptionalParameter("start_date_lt", startDateLt?.ToString())
                                .AddOptionalParameter("end_date_gte", endDateGte?.ToString())
                                .AddOptionalParameter("end_date_gt", endDateGt?.ToString())
                                .AddOptionalParameter("end_date_lte", endDateLte?.ToString())
                                .AddOptionalParameter("end_date_lt", endDateLt?.ToString())
                                .AddOptionalParameter("updated_at_gte", updatedAtGte?.ToString())
                                .AddOptionalParameter("updated_at_gt", updatedAtGt?.ToString())
                                .AddOptionalParameter("updated_at_lte", updatedAtLte?.ToString())
                                .AddOptionalParameter("updated_at_lt", updatedAtLt?.ToString())
                                .AddOptionalParameter("run_type", runType, delimiter: ",", explode: true)
                                .AddOptionalParameter("state", state, delimiter: ",", explode: true)
                                .AddOptionalParameter("dag_version", dagVersion, selector: static x => x.ToString()!, delimiter: ",", explode: true)
                                .AddOptionalParameter("order_by", orderBy, delimiter: ",", explode: true)
                                .AddOptionalParameter("run_id_pattern", runIdPattern)
                                .AddOptionalParameter("triggering_user_name_pattern", triggeringUserNamePattern)
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
                PrepareGetDagRunsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    dagId: dagId!,
                    limit: limit,
                    offset: offset,
                    runAfterGte: runAfterGte,
                    runAfterGt: runAfterGt,
                    runAfterLte: runAfterLte,
                    runAfterLt: runAfterLt,
                    logicalDateGte: logicalDateGte,
                    logicalDateGt: logicalDateGt,
                    logicalDateLte: logicalDateLte,
                    logicalDateLt: logicalDateLt,
                    startDateGte: startDateGte,
                    startDateGt: startDateGt,
                    startDateLte: startDateLte,
                    startDateLt: startDateLt,
                    endDateGte: endDateGte,
                    endDateGt: endDateGt,
                    endDateLte: endDateLte,
                    endDateLt: endDateLt,
                    updatedAtGte: updatedAtGte,
                    updatedAtGt: updatedAtGt,
                    updatedAtLte: updatedAtLte,
                    updatedAtLt: updatedAtLt,
                    runType: runType,
                    state: state,
                    dagVersion: dagVersion,
                    orderBy: orderBy,
                    runIdPattern: runIdPattern,
                    triggeringUserNamePattern: triggeringUserNamePattern);

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
                                operationId: "GetDagRuns",
                                methodName: "GetDagRunsAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns\"",
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
                                operationId: "GetDagRuns",
                                methodName: "GetDagRunsAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns\"",
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
                                operationId: "GetDagRuns",
                                methodName: "GetDagRunsAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns\"",
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
                ProcessGetDagRunsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetDagRuns",
                                methodName: "GetDagRunsAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns\"",
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
                                operationId: "GetDagRuns",
                                methodName: "GetDagRunsAsync",
                                pathTemplate: "$\"/api/v2/dags/{dagId}/dagRuns\"",
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
                                ProcessGetDagRunsResponseContent(
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
    }
}