# Client configuration

## Environment-based setup

The recommended setup keeps the JWT token outside source control:

```bash
export AIRFLOW_API_TOKEN="your-jwt-token"
export AIRFLOW_BASE_URL="https://airflow.example.com"
```

```csharp
using Loud.Technology.Airflow.Sdk;

using var client = AirflowClient.CreateFromEnvironment();
```

`CreateFromEnvironment()` throws `InvalidOperationException` when `AIRFLOW_API_TOKEN` is missing or empty. The generated default server URL is `http://localhost:8080`.

## Explicit setup

```csharp
using var client = new AirflowClient(
    apiKey: "your-jwt-token",
    baseUri: new Uri("https://airflow.example.com"));
```

The SDK sends the token as an `Authorization: Bearer` header. Never embed production credentials in source code.

## Application-managed HTTP transport

```csharp
using var httpClient = new HttpClient
{
    Timeout = TimeSpan.FromSeconds(90),
};

using var client = new AirflowClient(
    apiKey: Environment.GetEnvironmentVariable("AIRFLOW_API_TOKEN")!,
    httpClient: httpClient,
    baseUri: new Uri("https://airflow.example.com"),
    disposeHttpClient: false);
```

Set `disposeHttpClient: false` when the `HttpClient` lifetime is owned by your application or dependency-injection container.

## Token lifetime

Airflow JWT tokens can expire. Refresh tokens through the configured auth manager and create or reauthorize the client according to your application's credential lifecycle. Do not log tokens or include them in issue reports.
