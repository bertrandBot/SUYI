using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using SuyiRestApi.ATS;
using System;
using System.Collections.Generic;
using System.Linq;

public class AzureTableStorageProvider
{
    private const string _azureTableStorageConnectionString = "DefaultEndpointsProtocol=https;AccountName=suyitest;AccountKey=hvxlFcP8kWbZ/kjXkhs1FEtc41WIO+egL2F0PMcES55o74mMYdqECnqUgjEZ/KMyysyj5PoWyEPH6lijsTResw==;EndpointSuffix=core.windows.net";
    private CloudTableClient tableClient;

    public AzureTableStorageProvider()
    {
    }

    private CloudTableClient TableClient
    {
        get
        {
            if (tableClient == null)
            {
                CloudStorageAccount storageAccount = CloudStorageAccount.Parse(_azureTableStorageConnectionString);
                tableClient = storageAccount.CreateCloudTableClient();
            }

            return tableClient;
        }
    }

    public void ExecuteOperation(TableType tableType, TableOperation operation)
    {
        var cloudTable = GetTable(tableType.ToString());

        cloudTable.Execute(operation);
    }

    public CloudTable GetTable(string tableName)
    {
        CloudTable cloudTable = this.TableClient.GetTableReference(tableName);
        cloudTable.CreateIfNotExists();

        return cloudTable;
    }

    public List<T> FetchEntities<T>(string identifier, TableType tableType) where T : ITableEntity, new()
    {
        if (string.IsNullOrWhiteSpace(identifier))
        {
            throw new ArgumentNullException("identifier");
        }
        return FetchEntities<T>(identifier, tableType.ToString());
    }
    public List<T> FetchEntities<T>(string identifier, string tableName) where T : ITableEntity, new()
    {
        var table = GetTable(tableName);
        TableQuery<T> query = CreateQuery<T>(identifier);
        return FetchEntitiesWithContinueToken(table, query);
    }

    public T FetchEntities<T>(string partitionKey, string rowKey, string tableName) where T : ITableEntity, new()
    {
        if (string.IsNullOrWhiteSpace(partitionKey))
        {
            throw new ArgumentNullException("partitionKey");
        }

        if (string.IsNullOrWhiteSpace(rowKey))
        {
            throw new ArgumentNullException("rowKey");
        }

        var table = GetTable(tableName);
        TableQuery<T> query = CreateQuery<T>(partitionKey, rowKey);
        return FetchEntitiesWithContinueToken(table, query).SingleOrDefault();
    }

    public static TableQuery<T> CreateQuery<T>(string partitionKey, string rowKey)
    {
        string pkFilter = TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, partitionKey);

        string rkFilter = TableQuery.GenerateFilterCondition("RowKey", QueryComparisons.Equal, rowKey);

        string combinedFilter = TableQuery.CombineFilters(pkFilter, TableOperators.And, rkFilter);

        return new TableQuery<T>().Where(combinedFilter);
    }


    public List<T> FetchEntitiesWithContinueToken<T>(CloudTable table, TableQuery<T> query) where T : ITableEntity, new()
    {
        var results = new List<T>();
        var token = default(TableContinuationToken);
        do
        {
            var queryResult = table.ExecuteQuerySegmented(query, token);
            results.AddRange(queryResult.Results);
            token = queryResult.ContinuationToken;
        }
        while (token != null);
        return results;
    }

    public static TableQuery<T> CreateQuery<T>(string partitionKey)
    {
        return new TableQuery<T>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, partitionKey));
    }

}