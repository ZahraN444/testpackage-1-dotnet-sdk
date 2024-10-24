# Announcements

```csharp
AnnouncementsController announcementsController = client.AnnouncementsController;
```

## Class Name

`AnnouncementsController`


# Get Announcements

Lists any important updates posted by the Cycle team.

```csharp
GetAnnouncementsAsync(
    List<string> sort = null,
    Models.Page page = null,
    Models.Filter filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |
| `filter` | [`Filter`](../../doc/models/filter.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.AnnouncementsListResponse>`](../../doc/models/announcements-list-response.md)

## Example Usage

```csharp
try
{
    AnnouncementsListResponse result = await announcementsController.GetAnnouncementsAsync();
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

