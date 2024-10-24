# Search

```csharp
SearchController searchController = client.SearchController;
```

## Class Name

`SearchController`


# Get Search Index

Gets a pre-built search index, containing IDs and basic information for many commonly used resources on the Hub.
Can be used to build a 'quick search' functionality for referencing the most frequently used resources.

Requires the `view` capability for each returned segment, i.e. to retrieve Containers, you must have `containers-view`.

```csharp
GetSearchIndexAsync()
```

## Response Type

[`Task<Models.V1SearchIndexResponse>`](../../doc/models/v1-search-index-response.md)

## Example Usage

```csharp
try
{
    V1SearchIndexResponse result = await searchController.GetSearchIndexAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| Default | General error response from the platform | [`ErrorEnvelopeException`](../../doc/models/error-envelope-exception.md) |

