# Security

```csharp
SecurityController securityController = client.SecurityController;
```

## Class Name

`SecurityController`


# Get Security Report

Returns a report detailing incidents logged by the platform around security related events.

```csharp
GetSecurityReportAsync(
    Models.Filter33 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filter` | [`Filter33`](../../doc/models/filter-33.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.V1SecurityReportResponse>`](../../doc/models/v1-security-report-response.md)

## Example Usage

```csharp
Filter33 filter = new Filter33
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
    V1SecurityReportResponse result = await securityController.GetSecurityReportAsync(filter);
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

