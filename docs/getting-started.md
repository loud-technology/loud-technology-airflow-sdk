# Getting started

This guide installs the Apache Airflow .NET SDK, connects it to an API server, and lists DAGs.

## 1. Prepare Apache Airflow

You need Apache Airflow 3 with its API server reachable. A local deployment normally listens on:

```text
http://localhost:8080
```

The public REST API is rooted at `/api/v2`.

## 2. Obtain a JWT token

Airflow's public API uses JWT Bearer authentication. Obtain a token using the mechanism exposed by your configured auth manager. For example, an auth manager may expose `POST /auth/token` with username and password credentials.

Consult the [official Airflow API authentication documentation](https://airflow.apache.org/docs/apache-airflow/stable/security/api.html) and your auth manager's documentation. The SDK consumes an access token; it does not store usernames or passwords.

## 3. Install the package

=== "NuGet.org"

    ```bash
    dotnet add package Airflow
    ```

=== "GitHub Packages"

    ```bash
    export GITHUB_PACKAGES_USER="your-github-username"
    export GITHUB_PACKAGES_TOKEN="ghp_your-read-packages-token"

    dotnet nuget add source \
      --username "$GITHUB_PACKAGES_USER" \
      --password "$GITHUB_PACKAGES_TOKEN" \
      --store-password-in-clear-text \
      --name loud-technology \
      "https://nuget.pkg.github.com/loud-technology/index.json"

    dotnet add package Airflow \
      --source "https://nuget.pkg.github.com/loud-technology/index.json"
    ```

## 4. Configure the client

=== "macOS and Linux"

    ```bash
    export AIRFLOW_API_TOKEN="your-jwt-token"
    export AIRFLOW_BASE_URL="http://localhost:8080"
    ```

=== "PowerShell"

    ```powershell
    $env:AIRFLOW_API_TOKEN = "your-jwt-token"
    $env:AIRFLOW_BASE_URL = "http://localhost:8080"
    ```

Never commit JWT tokens or production API server URLs.

## 5. List DAGs

```csharp
using Loud.Technology.Airflow.Sdk;

using var client = AirflowClient.CreateFromEnvironment();

var response = await client.Dag.GetDagsAsync(limit: 20);

foreach (var dag in response.Dags)
{
    Console.WriteLine($"{dag.DagId}: paused={dag.IsPaused}");
}
```

## 6. Handle cancellation and HTTP metadata

```csharp
using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(30));

try
{
    var response = await client.Monitor.GetHealthAsResponseAsync(
        cancellationToken: timeout.Token);

    Console.WriteLine($"Airflow API status: {(int)response.StatusCode}");
}
catch (ApiException exception)
{
    Console.Error.WriteLine($"Airflow request failed: {exception.Message}");
}
```

Non-success responses throw `ApiException`. Keep logs sanitized because Airflow responses can contain workflow metadata, configuration, or task output.
