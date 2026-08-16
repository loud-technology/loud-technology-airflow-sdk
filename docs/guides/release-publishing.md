# Release publishing

Stable releases are published from semantic version tags to two NuGet-compatible registries:

| Destination | Authentication | Published artifact |
|---|---|---|
| [NuGet.org](https://www.nuget.org/packages/Airflow/) | Trusted Publishing with GitHub OIDC | `.nupkg` and symbol package |
| [GitHub Packages](https://github.com/orgs/loud-technology/packages?repo_name=loud-technology-airflow-sdk) | Workflow `GITHUB_TOKEN` | `.nupkg` |

The build job creates one immutable package. Both publishing jobs download that workflow artifact, keeping contents and versions identical across registries.

## Configure NuGet.org Trusted Publishing

In the NuGet.org account or organization that owns the `Airflow` package ID, create a Trusted Publishing policy with:

| Policy field | Value |
|---|---|
| Repository Owner | `loud-technology` |
| Repository | `loud-technology-airflow-sdk` |
| Workflow File | `dotnet.yml` |
| Environment | `nuget-org` |

Enter only `dotnet.yml` in **Workflow File**, not `.github/workflows/dotnet.yml`.

## Configure GitHub Actions

1. Create the `nuget-org` environment under repository settings.
2. Optionally add required reviewers or tag protection.
3. Add an Actions variable named `NUGET_USER` at repository, organization, or environment scope.
4. Set `NUGET_USER` to the NuGet.org profile username, not an email address.

No long-lived NuGet API key is stored. `NuGet/login@v1` exchanges the GitHub OIDC token for a temporary API key. GitHub Packages uses the workflow's built-in `GITHUB_TOKEN` with job-scoped `packages: write`.

## Publish a stable release

```bash
git tag v1.0.0
git push origin v1.0.0
```

MinVer converts `v1.0.0` into package version `1.0.0`. The workflow restores, builds, tests, packs, uploads the package artifact, and publishes it to both registries. Untagged `main` builds create development artifacts but do not publish.

## Troubleshooting

- **OIDC exchange rejected:** verify all Trusted Publishing policy fields, especially `dotnet.yml` and `nuget-org`.
- **Username rejected:** confirm `NUGET_USER` is the profile username rather than an email.
- **Package ownership rejected:** ensure the policy owner owns or may create the package ID.
- **Environment waiting:** approve the deployment if required reviewers are enabled.
- **Duplicate version:** package versions are immutable; publish a new semantic version.
