
#nullable enable

namespace Loud.Technology.Airflow.Sdk
{
    public partial class DagClient
    {


        private static readonly global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement s_GetDagsSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement[] s_GetDagsSecurityRequirements =
            new global::Loud.Technology.Airflow.Sdk.EndPointSecurityRequirement[]
            {                s_GetDagsSecurityRequirement0,
            };
        partial void PrepareGetDagsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref int? offset,
            global::System.Collections.Generic.IList<string>? tags,
            global::Loud.Technology.Airflow.Sdk.GetDagsTagsMatchMode2? tagsMatchMode,
            global::System.Collections.Generic.IList<string>? owners,
            ref string? dagIdPattern,
            ref string? dagDisplayNamePattern,
            ref bool? excludeStale,
            bool? paused,
            bool? hasImportErrors,
            global::Loud.Technology.Airflow.Sdk.DagRunState? lastDagRunState,
            ref string? bundleName,
            ref string? bundleVersion,
            bool? hasAssetSchedule,
            ref string? assetDependency,
            global::System.DateTime? dagRunStartDateGte,
            global::System.DateTime? dagRunStartDateGt,
            global::System.DateTime? dagRunStartDateLte,
            global::System.DateTime? dagRunStartDateLt,
            global::System.DateTime? dagRunEndDateGte,
            global::System.DateTime? dagRunEndDateGt,
            global::System.DateTime? dagRunEndDateLte,
            global::System.DateTime? dagRunEndDateLt,
            global::System.Collections.Generic.IList<string>? dagRunState,
            global::System.Collections.Generic.IList<string>? orderBy,
            bool? isFavorite);
        partial void PrepareGetDagsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<string>? tags,
            global::Loud.Technology.Airflow.Sdk.GetDagsTagsMatchMode2? tagsMatchMode,
            global::System.Collections.Generic.IList<string>? owners,
            string? dagIdPattern,
            string? dagDisplayNamePattern,
            bool? excludeStale,
            bool? paused,
            bool? hasImportErrors,
            global::Loud.Technology.Airflow.Sdk.DagRunState? lastDagRunState,
            string? bundleName,
            string? bundleVersion,
            bool? hasAssetSchedule,
            string? assetDependency,
            global::System.DateTime? dagRunStartDateGte,
            global::System.DateTime? dagRunStartDateGt,
            global::System.DateTime? dagRunStartDateLte,
            global::System.DateTime? dagRunStartDateLt,
            global::System.DateTime? dagRunEndDateGte,
            global::System.DateTime? dagRunEndDateGt,
            global::System.DateTime? dagRunEndDateLte,
            global::System.DateTime? dagRunEndDateLt,
            global::System.Collections.Generic.IList<string>? dagRunState,
            global::System.Collections.Generic.IList<string>? orderBy,
            bool? isFavorite);
        partial void ProcessGetDagsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDagsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Dags<br/>
        /// Get all DAGs.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tags"></param>
        /// <param name="tagsMatchMode"></param>
        /// <param name="owners"></param>
        /// <param name="dagIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="dagDisplayNamePattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="excludeStale">
        /// Default Value: true
        /// </param>
        /// <param name="paused"></param>
        /// <param name="hasImportErrors">
        /// Filter Dags by having import errors. Only Dags that have been successfully loaded before will be returned.
        /// </param>
        /// <param name="lastDagRunState"></param>
        /// <param name="bundleName"></param>
        /// <param name="bundleVersion"></param>
        /// <param name="hasAssetSchedule">
        /// Filter Dags with asset-based scheduling
        /// </param>
        /// <param name="assetDependency">
        /// Filter Dags by asset dependency (name or URI)
        /// </param>
        /// <param name="dagRunStartDateGte"></param>
        /// <param name="dagRunStartDateGt"></param>
        /// <param name="dagRunStartDateLte"></param>
        /// <param name="dagRunStartDateLt"></param>
        /// <param name="dagRunEndDateGte"></param>
        /// <param name="dagRunEndDateGt"></param>
        /// <param name="dagRunEndDateLte"></param>
        /// <param name="dagRunEndDateLt"></param>
        /// <param name="dagRunState"></param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `dag_id, dag_display_name, next_dagrun, state, start_date, last_run_state, last_run_start_date`<br/>
        /// Default Value: [dag_id]
        /// </param>
        /// <param name="isFavorite"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse> GetDagsAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Loud.Technology.Airflow.Sdk.GetDagsTagsMatchMode2? tagsMatchMode = default,
            global::System.Collections.Generic.IList<string>? owners = default,
            string? dagIdPattern = default,
            string? dagDisplayNamePattern = default,
            bool? excludeStale = default,
            bool? paused = default,
            bool? hasImportErrors = default,
            global::Loud.Technology.Airflow.Sdk.DagRunState? lastDagRunState = default,
            string? bundleName = default,
            string? bundleVersion = default,
            bool? hasAssetSchedule = default,
            string? assetDependency = default,
            global::System.DateTime? dagRunStartDateGte = default,
            global::System.DateTime? dagRunStartDateGt = default,
            global::System.DateTime? dagRunStartDateLte = default,
            global::System.DateTime? dagRunStartDateLt = default,
            global::System.DateTime? dagRunEndDateGte = default,
            global::System.DateTime? dagRunEndDateGt = default,
            global::System.DateTime? dagRunEndDateLte = default,
            global::System.DateTime? dagRunEndDateLt = default,
            global::System.Collections.Generic.IList<string>? dagRunState = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            bool? isFavorite = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetDagsAsResponseAsync(
                limit: limit,
                offset: offset,
                tags: tags,
                tagsMatchMode: tagsMatchMode,
                owners: owners,
                dagIdPattern: dagIdPattern,
                dagDisplayNamePattern: dagDisplayNamePattern,
                excludeStale: excludeStale,
                paused: paused,
                hasImportErrors: hasImportErrors,
                lastDagRunState: lastDagRunState,
                bundleName: bundleName,
                bundleVersion: bundleVersion,
                hasAssetSchedule: hasAssetSchedule,
                assetDependency: assetDependency,
                dagRunStartDateGte: dagRunStartDateGte,
                dagRunStartDateGt: dagRunStartDateGt,
                dagRunStartDateLte: dagRunStartDateLte,
                dagRunStartDateLt: dagRunStartDateLt,
                dagRunEndDateGte: dagRunEndDateGte,
                dagRunEndDateGt: dagRunEndDateGt,
                dagRunEndDateLte: dagRunEndDateLte,
                dagRunEndDateLt: dagRunEndDateLt,
                dagRunState: dagRunState,
                orderBy: orderBy,
                isFavorite: isFavorite,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Dags<br/>
        /// Get all DAGs.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tags"></param>
        /// <param name="tagsMatchMode"></param>
        /// <param name="owners"></param>
        /// <param name="dagIdPattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="dagDisplayNamePattern">
        /// SQL LIKE expression — use `%` / `_` wildcards (e.g. `%customer_%`). Regular expressions are **not** supported.
        /// </param>
        /// <param name="excludeStale">
        /// Default Value: true
        /// </param>
        /// <param name="paused"></param>
        /// <param name="hasImportErrors">
        /// Filter Dags by having import errors. Only Dags that have been successfully loaded before will be returned.
        /// </param>
        /// <param name="lastDagRunState"></param>
        /// <param name="bundleName"></param>
        /// <param name="bundleVersion"></param>
        /// <param name="hasAssetSchedule">
        /// Filter Dags with asset-based scheduling
        /// </param>
        /// <param name="assetDependency">
        /// Filter Dags by asset dependency (name or URI)
        /// </param>
        /// <param name="dagRunStartDateGte"></param>
        /// <param name="dagRunStartDateGt"></param>
        /// <param name="dagRunStartDateLte"></param>
        /// <param name="dagRunStartDateLt"></param>
        /// <param name="dagRunEndDateGte"></param>
        /// <param name="dagRunEndDateGt"></param>
        /// <param name="dagRunEndDateLte"></param>
        /// <param name="dagRunEndDateLt"></param>
        /// <param name="dagRunState"></param>
        /// <param name="orderBy">
        /// Attributes to order by, multi criteria sort is supported. Prefix with `-` for descending order. Supported attributes: `dag_id, dag_display_name, next_dagrun, state, start_date, last_run_state, last_run_start_date`<br/>
        /// Default Value: [dag_id]
        /// </param>
        /// <param name="isFavorite"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Airflow.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse>> GetDagsAsResponseAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::Loud.Technology.Airflow.Sdk.GetDagsTagsMatchMode2? tagsMatchMode = default,
            global::System.Collections.Generic.IList<string>? owners = default,
            string? dagIdPattern = default,
            string? dagDisplayNamePattern = default,
            bool? excludeStale = default,
            bool? paused = default,
            bool? hasImportErrors = default,
            global::Loud.Technology.Airflow.Sdk.DagRunState? lastDagRunState = default,
            string? bundleName = default,
            string? bundleVersion = default,
            bool? hasAssetSchedule = default,
            string? assetDependency = default,
            global::System.DateTime? dagRunStartDateGte = default,
            global::System.DateTime? dagRunStartDateGt = default,
            global::System.DateTime? dagRunStartDateLte = default,
            global::System.DateTime? dagRunStartDateLt = default,
            global::System.DateTime? dagRunEndDateGte = default,
            global::System.DateTime? dagRunEndDateGt = default,
            global::System.DateTime? dagRunEndDateLte = default,
            global::System.DateTime? dagRunEndDateLt = default,
            global::System.Collections.Generic.IList<string>? dagRunState = default,
            global::System.Collections.Generic.IList<string>? orderBy = default,
            bool? isFavorite = default,
            global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetDagsArguments(
                httpClient: HttpClient,
                limit: ref limit,
                offset: ref offset,
                tags: tags,
                tagsMatchMode: tagsMatchMode,
                owners: owners,
                dagIdPattern: ref dagIdPattern,
                dagDisplayNamePattern: ref dagDisplayNamePattern,
                excludeStale: ref excludeStale,
                paused: paused,
                hasImportErrors: hasImportErrors,
                lastDagRunState: lastDagRunState,
                bundleName: ref bundleName,
                bundleVersion: ref bundleVersion,
                hasAssetSchedule: hasAssetSchedule,
                assetDependency: ref assetDependency,
                dagRunStartDateGte: dagRunStartDateGte,
                dagRunStartDateGt: dagRunStartDateGt,
                dagRunStartDateLte: dagRunStartDateLte,
                dagRunStartDateLt: dagRunStartDateLt,
                dagRunEndDateGte: dagRunEndDateGte,
                dagRunEndDateGt: dagRunEndDateGt,
                dagRunEndDateLte: dagRunEndDateLte,
                dagRunEndDateLt: dagRunEndDateLt,
                dagRunState: dagRunState,
                orderBy: orderBy,
                isFavorite: isFavorite);


            var __authorizations = global::Loud.Technology.Airflow.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetDagsSecurityRequirements,
                operationName: "GetDagsAsync");

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
                                path: "/api/v2/dags",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("tags", tags, delimiter: ",", explode: true)
                                .AddOptionalParameter("tags_match_mode", tagsMatchMode?.ToString())
                                .AddOptionalParameter("owners", owners, delimiter: ",", explode: true)
                                .AddOptionalParameter("dag_id_pattern", dagIdPattern)
                                .AddOptionalParameter("dag_display_name_pattern", dagDisplayNamePattern)
                                .AddOptionalParameter("exclude_stale", excludeStale?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("paused", paused?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("has_import_errors", hasImportErrors?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("last_dag_run_state", lastDagRunState?.ToString())
                                .AddOptionalParameter("bundle_name", bundleName)
                                .AddOptionalParameter("bundle_version", bundleVersion)
                                .AddOptionalParameter("has_asset_schedule", hasAssetSchedule?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("asset_dependency", assetDependency)
                                .AddOptionalParameter("dag_run_start_date_gte", dagRunStartDateGte?.ToString())
                                .AddOptionalParameter("dag_run_start_date_gt", dagRunStartDateGt?.ToString())
                                .AddOptionalParameter("dag_run_start_date_lte", dagRunStartDateLte?.ToString())
                                .AddOptionalParameter("dag_run_start_date_lt", dagRunStartDateLt?.ToString())
                                .AddOptionalParameter("dag_run_end_date_gte", dagRunEndDateGte?.ToString())
                                .AddOptionalParameter("dag_run_end_date_gt", dagRunEndDateGt?.ToString())
                                .AddOptionalParameter("dag_run_end_date_lte", dagRunEndDateLte?.ToString())
                                .AddOptionalParameter("dag_run_end_date_lt", dagRunEndDateLt?.ToString())
                                .AddOptionalParameter("dag_run_state", dagRunState, delimiter: ",", explode: true)
                                .AddOptionalParameter("order_by", orderBy, delimiter: ",", explode: true)
                                .AddOptionalParameter("is_favorite", isFavorite?.ToString().ToLowerInvariant())
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
                PrepareGetDagsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    limit: limit,
                    offset: offset,
                    tags: tags,
                    tagsMatchMode: tagsMatchMode,
                    owners: owners,
                    dagIdPattern: dagIdPattern,
                    dagDisplayNamePattern: dagDisplayNamePattern,
                    excludeStale: excludeStale,
                    paused: paused,
                    hasImportErrors: hasImportErrors,
                    lastDagRunState: lastDagRunState,
                    bundleName: bundleName,
                    bundleVersion: bundleVersion,
                    hasAssetSchedule: hasAssetSchedule,
                    assetDependency: assetDependency,
                    dagRunStartDateGte: dagRunStartDateGte,
                    dagRunStartDateGt: dagRunStartDateGt,
                    dagRunStartDateLte: dagRunStartDateLte,
                    dagRunStartDateLt: dagRunStartDateLt,
                    dagRunEndDateGte: dagRunEndDateGte,
                    dagRunEndDateGt: dagRunEndDateGt,
                    dagRunEndDateLte: dagRunEndDateLte,
                    dagRunEndDateLt: dagRunEndDateLt,
                    dagRunState: dagRunState,
                    orderBy: orderBy,
                    isFavorite: isFavorite);

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
                                operationId: "GetDags",
                                methodName: "GetDagsAsync",
                                pathTemplate: "\"/api/v2/dags\"",
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
                                operationId: "GetDags",
                                methodName: "GetDagsAsync",
                                pathTemplate: "\"/api/v2/dags\"",
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
                                operationId: "GetDags",
                                methodName: "GetDagsAsync",
                                pathTemplate: "\"/api/v2/dags\"",
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
                ProcessGetDagsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Airflow.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetDags",
                                methodName: "GetDagsAsync",
                                pathTemplate: "\"/api/v2/dags\"",
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
                                operationId: "GetDags",
                                methodName: "GetDagsAsync",
                                pathTemplate: "\"/api/v2/dags\"",
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
                                ProcessGetDagsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse>(
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

                                    var __value = await global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.Airflow.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Airflow.Sdk.DAGCollectionResponse>(
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