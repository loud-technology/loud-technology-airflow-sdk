# Apache Airflow .NET SDK

**A strongly typed .NET client for the Apache Airflow public REST API, maintained by [loud-technology](https://github.com/loud-technology).**

The SDK lets .NET applications inspect and operate Airflow without maintaining custom HTTP request code. It is generated from Apache Airflow's official OpenAPI specification with AutoSDK, then built, tested, packaged, and documented as a native .NET library.

<div class="grid cards" markdown>

-   :material-graph:{ .lg .middle } **Operate workflows**

    ---

    Discover DAGs, trigger runs, inspect tasks, manage variables and connections, and monitor the API.

-   :material-code-braces:{ .lg .middle } **Strongly typed API**

    ---

    Explore resource clients, request models, enums, cancellation tokens, and response helpers through IntelliSense.

-   :material-update:{ .lg .middle } **Generated from Apache Airflow**

    ---

    Reproducible generation from the official Airflow public API definition reduces drift as the platform evolves.

-   :material-package-variant:{ .lg .middle } **Release-ready package**

    ---

    Signed assemblies, source symbols, MinVer, Source Link, and publishing to NuGet.org and GitHub Packages.

</div>

## Start here

1. Follow [Getting started](getting-started.md) to install the package, configure a JWT token, and list DAGs.
2. Read [Client configuration](guides/configuration.md) for environment variables, explicit credentials, and `HttpClient` ownership.
3. Explore generated endpoint groups with IDE completion for the exact API available in your package version.

## What the SDK covers

The generated client exposes the stable Airflow 3 public API under `/api/v2`, including:

- DAGs, DAG runs, tasks, task instances, and XComs;
- assets, backfills, pools, variables, and connections;
- providers, plugins, event logs, import errors, jobs, and configuration;
- server health and version information.

!!! note "Community SDK"
    This project is maintained by loud-technology and generated from the Apache Airflow OpenAPI specification. It is not an official Apache Software Foundation SDK.

## Requirements

- .NET 10 or later
- A reachable Apache Airflow 3 API server
- A JWT access token issued by the configured Airflow auth manager

The default server URL is `http://localhost:8080`.

## Project links

- [Source repository](https://github.com/loud-technology/loud-technology-airflow-sdk)
- [NuGet.org package](https://www.nuget.org/packages/Airflow/)
- [GitHub Packages](https://github.com/orgs/loud-technology/packages?repo_name=loud-technology-airflow-sdk)
- [Issue tracker](https://github.com/loud-technology/loud-technology-airflow-sdk/issues)
- [Official Apache Airflow documentation](https://airflow.apache.org/docs/)
