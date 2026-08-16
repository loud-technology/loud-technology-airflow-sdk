/*
order: 10
title: List DAGs
slug: list-dags

List DAGs from an Apache Airflow API server.
*/

// ReSharper disable once CheckNamespace
namespace Loud.Technology.Airflow.Sdk.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListDags()
    {
        using var client = GetAuthenticatedClient();

        var response = await client.Dag.GetDagsAsync(limit: 20);

        response.Dags.Should().NotBeNull();
    }
}
