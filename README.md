<div align="center">
  <img src="assets/nuget-icon.png" alt="Apache Airflow .NET SDK" width="112" />
  <h1>Apache Airflow .NET SDK</h1>
  <p><strong>Operate Apache Airflow from .NET with a native, strongly typed client.</strong></p>
  <p>Use generated C# models, async APIs, source-generated JSON serialization, and an SDK that tracks Airflow's public OpenAPI surface.</p>

  [![NuGet](https://img.shields.io/nuget/vpre/Airflow?logo=nuget&label=NuGet.org)](https://www.nuget.org/packages/Airflow/)
  [![GitHub Packages](https://img.shields.io/badge/GitHub%20Packages-NuGet-181717?logo=github)](https://github.com/orgs/loud-technology/packages?repo_name=loud-technology-airflow-sdk)
  [![CI](https://github.com/loud-technology/loud-technology-airflow-sdk/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/loud-technology/loud-technology-airflow-sdk/actions/workflows/dotnet.yml)
  [![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
  [![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
</div>

---

## Why Apache Airflow for .NET?

Apache Airflow is a platform for developing, scheduling, and monitoring batch-oriented workflows. This SDK exposes the stable Airflow 3 public REST API to .NET applications without hand-written HTTP plumbing.

- **Broad API coverage** — DAGs, DAG runs, tasks, task instances, assets, connections, variables, pools, providers, event logs, health, and more.
- **Strongly typed by default** — generated request and response models, enums, endpoint clients, cancellation, and raw HTTP response helpers.
- **Built for modern .NET** — nullable reference types, analyzers, source-generated `System.Text.Json`, trimming analysis, NativeAOT awareness, assembly signing, and reproducible builds.
- **Spec-driven updates** — regenerate from Apache Airflow's official OpenAPI definition with one script; scheduled automation detects upstream changes.
- **Release-ready packages** — MinVer derives versions from Git tags, Source Link connects packages to source, and symbol packages improve debugging.

> [!NOTE]
> This community SDK is maintained by loud-technology and generated from the Apache Airflow OpenAPI specification. It is not an official Apache Software Foundation SDK.

## Requirements

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later to build
- Apache Airflow 3 with its API server reachable
- A valid JWT access token issued by the configured Airflow auth manager

A local Airflow API server normally listens on `http://localhost:8080`. The public API is rooted at `/api/v2`.

## Install

### NuGet.org

```bash
dotnet add package Airflow
```

### GitHub Packages

Create a classic personal access token with `read:packages`, then register the loud-technology source:

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

Never commit package credentials or Airflow JWT tokens.

## Quick start

Obtain a JWT token according to the configured Airflow auth manager. For example, the simple auth manager can expose `POST /auth/token`. Then configure the SDK:

```bash
export AIRFLOW_API_TOKEN="your-jwt-token"
export AIRFLOW_BASE_URL="http://localhost:8080"
```

List DAGs:

```csharp
using Loud.Technology.Airflow.Sdk;

using var client = AirflowClient.CreateFromEnvironment();

var response = await client.Dag.GetDagsAsync(limit: 20);

foreach (var dag in response.Dags)
{
    Console.WriteLine($"{dag.DagId}: paused={dag.IsPaused}");
}
```

## Configure the client

### Explicit token and API server URL

```csharp
using var client = new AirflowClient(
    apiKey: "your-jwt-token",
    baseUri: new Uri("https://airflow.example.com"));
```

### Reuse `HttpClient`

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

| Variable | Purpose | Default |
|---|---|---|
| `AIRFLOW_API_TOKEN` | JWT Bearer credential used by `CreateFromEnvironment()` | Required by the factory |
| `AIRFLOW_BASE_URL` | Base URL of the Airflow API server | `http://localhost:8080` |

## API surface

The root client groups operations by Airflow resource:

```csharp
client.Dag;          // DAG discovery and management
client.DagRun;       // Trigger and inspect DAG runs
client.Task;         // Task definitions
client.TaskInstance; // Task instance state and logs
client.Asset;        // Asset definitions and events
client.Connection;   // Airflow connections
client.Variable;     // Airflow variables
client.Pool;         // Worker pools
client.Monitor;      // API health
client.Version;      // Server version
```

Rely on IDE completion and generated XML documentation for the exact operations and models in the installed package version.

## Errors, cancellation, and HTTP metadata

Every async operation accepts a `CancellationToken`. Non-success HTTP responses throw `ApiException`. Methods ending in `AsResponseAsync` return an `AutoSDKHttpResponse<T>` when status and headers are needed with the response body.

```csharp
using var cancellation = new CancellationTokenSource(TimeSpan.FromSeconds(30));

try
{
    var response = await client.Monitor.GetHealthAsResponseAsync(
        cancellationToken: cancellation.Token);

    Console.WriteLine($"Airflow API status: {(int)response.StatusCode}");
}
catch (ApiException exception)
{
    Console.Error.WriteLine($"Airflow request failed: {exception.Message}");
}
```

## Regenerate the SDK

The generator downloads the current public API definition from Apache Airflow's `main` branch and recreates `Generated/` reproducibly with a pinned AutoSDK version:

```bash
dotnet tool install --global autosdk.cli --version 0.30.2-dev.152
./src/libs/Airflow/generate.sh
```

```text
Loud.Technology.Airflow.Sdk.slnx
├── src/
│   ├── libs/Airflow/
│   │   ├── Loud.Technology.Airflow.Sdk.csproj
│   │   ├── openapi.yaml
│   │   ├── generate.sh
│   │   └── Generated/
│   └── tests/IntegrationTests/
├── docs/
└── .github/workflows/
```

## Build and test

```bash
dotnet restore Loud.Technology.Airflow.Sdk.slnx
dotnet build Loud.Technology.Airflow.Sdk.slnx --configuration Release --no-restore
dotnet test Loud.Technology.Airflow.Sdk.slnx --configuration Release --no-build
```

Network-free contract tests verify the default URL, Bearer authorization, and the public health route. The live DAG example runs only when `AIRFLOW_API_TOKEN` is set; otherwise MSTest marks it inconclusive.

## Versioning and releases

Packages use [MinVer](https://github.com/adamralph/minver). Push a semantic version tag to publish the same build artifact to NuGet.org and GitHub Packages:

```bash
git tag v1.0.0
git push origin v1.0.0
```

NuGet.org uses Trusted Publishing through GitHub OIDC; GitHub Packages uses the workflow `GITHUB_TOKEN`. See [Release publishing](docs/guides/release-publishing.md) for repository setup.

## Contributing

1. Create a focused branch.
2. Change `generate.sh` or the surrounding SDK infrastructure rather than editing generated C# manually.
3. Regenerate when the upstream API changes.
4. Run the Release build and tests before opening a pull request.

Generated files are intentionally committed so builds are deterministic and consumers can inspect the exact API surface.

## License

Licensed under the [MIT License](LICENSE). Apache Airflow is a separate project under the Apache License 2.0. Apache Airflow, Apache, Airflow, and the Airflow logo are trademarks of The Apache Software Foundation.

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->


## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
