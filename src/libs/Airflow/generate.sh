#!/usr/bin/env bash
set -euo pipefail

cd "$(dirname "${BASH_SOURCE[0]}")"

readonly AUTOSDK_VERSION="0.30.2-dev.152"
readonly OPENAPI_URL="https://raw.githubusercontent.com/apache/airflow/main/airflow-core/src/airflow/api_fastapi/core_api/openapi/v2-rest-api-generated.yaml"
readonly DEFAULT_BASE_URL="http://localhost:8080"

if ! command -v autosdk >/dev/null 2>&1; then
  dotnet tool install --global autosdk.cli --version "${AUTOSDK_VERSION}"
fi

openapi_tmp="$(mktemp)"
trap 'rm -f "${openapi_tmp}"' EXIT

#curl --fail --location --silent --show-error "${OPENAPI_URL}" --output "${openapi_tmp}"
#mv "${openapi_tmp}" openapi.yaml
#rm -rf Generated

autosdk generate openapi.yaml \
  --namespace Loud.Technology.Airflow.Sdk \
  --clientClassName AirflowClient \
  --targetFramework net10.0 \
  --output Generated \
  --base-url "${DEFAULT_BASE_URL}" \
  --base-url-env AIRFLOW_BASE_URL \
  --security-scheme Http:Header:Bearer \
  --api-key-env AIRFLOW_API_TOKEN \
  --exclude-deprecated-operations
