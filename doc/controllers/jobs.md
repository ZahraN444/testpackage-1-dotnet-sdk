# Jobs

Jobs are calls which refer to managing job resources.

```csharp
JobsController jobsController = client.JobsController;
```

## Class Name

`JobsController`

## Methods

* [Get Jobs](../../doc/controllers/jobs.md#get-jobs)
* [Get Job](../../doc/controllers/jobs.md#get-job)
* [Get Latest Jobs](../../doc/controllers/jobs.md#get-latest-jobs)


# Get Jobs

Requires the `apionly-jobs-view` permission.

```csharp
GetJobsAsync(
    List<Models.Include12Enum> include = null,
    Models.Filter27 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `include` | [`List<Include12Enum>`](../../doc/models/include-12-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter27`](../../doc/models/filter-27.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1JobsResponse>`](../../doc/models/v1-jobs-response.md)

## Example Usage

```csharp
Filter27 filter = new Filter27
{
    RangeStart = DateTime.ParseExact("01/30/2021 08:30:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    RangeEnd = DateTime.ParseExact("01/30/2021 08:30:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};

try
{
    V1JobsResponse result = await jobsController.GetJobsAsync(
        null,
        filter
    );
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


# Get Job

Requires the `apionly-jobs-view` permission.

```csharp
GetJobAsync(
    string jobId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `jobId` | `string` | Template, Required | The ID for the given Job. |

## Response Type

[`Task<Models.V1JobsResponse1>`](../../doc/models/v1-jobs-response-1.md)

## Example Usage

```csharp
string jobId = "jobId0";
try
{
    V1JobsResponse1 result = await jobsController.GetJobAsync(jobId);
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


# Get Latest Jobs

Requires the `apionly-jobs-view` permission.

```csharp
GetLatestJobsAsync()
```

## Response Type

[`Task<Models.V1JobsLatestResponse>`](../../doc/models/v1-jobs-latest-response.md)

## Example Usage

```csharp
try
{
    V1JobsLatestResponse result = await jobsController.GetLatestJobsAsync();
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

