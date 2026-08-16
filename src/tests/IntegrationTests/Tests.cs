namespace Loud.Technology.Airflow.Sdk.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AirflowClient GetAuthenticatedClient()
    {
        var apiToken = Environment.GetEnvironmentVariable("AIRFLOW_API_TOKEN") is { Length: > 0 } tokenValue
            ? tokenValue
            : throw new AssertInconclusiveException("AIRFLOW_API_TOKEN environment variable is not set.");

        var baseUrl = Environment.GetEnvironmentVariable("AIRFLOW_BASE_URL") ?? AirflowClient.DefaultBaseUrl;

        return new AirflowClient(apiKey: apiToken, baseUri: new Uri(baseUrl));
    }
}
