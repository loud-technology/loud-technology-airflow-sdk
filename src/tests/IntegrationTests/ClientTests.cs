using System.Net;
using System.Net.Http.Headers;
using System.Text;

namespace Loud.Technology.Airflow.Sdk.IntegrationTests;

[TestClass]
public sealed class ClientTests
{
    [TestMethod]
    public void Constructor_ConfiguresDefaultBaseUrlAndBearerAuthentication()
    {
        using var client = new AirflowClient("test-jwt-token");

        client.BaseUri.Should().Be(new Uri("http://localhost:8080/"));
        var authorization = client.Authorizations.Should().ContainSingle().Which;
        authorization.Type.Should().Be("Http");
        authorization.Name.Should().Be("Bearer");
        authorization.Value.Should().Be("test-jwt-token");
    }

    [TestMethod]
    public async Task GetHealth_SendsExpectedRequest()
    {
        var handler = new RecordingHandler(
            new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(
                    """{"metadatabase":{"status":"healthy"},"scheduler":{"status":"healthy","latest_scheduler_heartbeat":null},"triggerer":{"status":"healthy","latest_triggerer_heartbeat":null}}""",
                    Encoding.UTF8,
                    "application/json"),
            });
        using var httpClient = new HttpClient(handler);
        using var client = new AirflowClient(
            apiKey: "test-jwt-token",
            httpClient: httpClient,
            baseUri: new Uri("https://airflow.example.com"),
            disposeHttpClient: false);

        await client.Monitor.GetHealthAsync();

        handler.Method.Should().Be(HttpMethod.Get);
        handler.RequestUri.Should().Be(new Uri("https://airflow.example.com/api/v2/monitor/health"));
        handler.Authorization.Should().Be(new AuthenticationHeaderValue("Bearer", "test-jwt-token"));
    }

    private sealed class RecordingHandler(HttpResponseMessage response) : HttpMessageHandler
    {
        public HttpMethod? Method { get; private set; }
        public Uri? RequestUri { get; private set; }
        public AuthenticationHeaderValue? Authorization { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            Method = request.Method;
            RequestUri = request.RequestUri;
            Authorization = request.Headers.Authorization;

            return Task.FromResult(response);
        }
    }
}
