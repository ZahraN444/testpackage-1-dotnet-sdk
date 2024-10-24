# Image Sources

```csharp
ImageSourcesController imageSourcesController = client.ImageSourcesController;
```

## Class Name

`ImageSourcesController`

## Methods

* [Get Image Sources](../../doc/controllers/image-sources.md#get-image-sources)
* [Create Image Source](../../doc/controllers/image-sources.md#create-image-source)
* [Get Image Source](../../doc/controllers/image-sources.md#get-image-source)
* [Update Image Source](../../doc/controllers/image-sources.md#update-image-source)
* [Delete Image Source](../../doc/controllers/image-sources.md#delete-image-source)


# Get Image Sources

Requires the `images-sources-view` capability.

```csharp
GetImageSourcesAsync(
    List<Models.Meta26Enum> meta = null,
    List<Models.Include23Enum> include = null,
    Models.Filter19 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `meta` | [`List<Meta26Enum>`](../../doc/models/meta-26-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include23Enum>`](../../doc/models/include-23-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter19`](../../doc/models/filter-19.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1ImagesSourcesResponse>`](../../doc/models/v1-images-sources-response.md)

## Example Usage

```csharp
try
{
    V1ImagesSourcesResponse result = await imageSourcesController.GetImageSourcesAsync();
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


# Create Image Source

Requires the `images-sources-manage` capability.

```csharp
CreateImageSourceAsync(
    Models.V1ImagesSourcesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1ImagesSourcesRequest`](../../doc/models/v1-images-sources-request.md) | Body, Optional | Parameters for creating an Image Source. |

## Response Type

[`Task<Models.V1ImagesSourcesResponse1>`](../../doc/models/v1-images-sources-response-1.md)

## Example Usage

```csharp
V1ImagesSourcesRequest body = new V1ImagesSourcesRequest
{
    Type = ImageSourceTypeEnum.Direct,
    Origin = ImageOrigin.FromDockerHubOrigin(
        new DockerHubOrigin
        {
            Type = "docker-hub",
            Details = new Details4
            {
                Target = "target8",
            },
        }
    ),
};

try
{
    V1ImagesSourcesResponse1 result = await imageSourcesController.CreateImageSourceAsync(body);
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


# Get Image Source

Requires the `images-sources-view` capability.

```csharp
GetImageSourceAsync(
    string sourceId,
    List<Models.Meta26Enum> meta = null,
    List<Models.Include23Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sourceId` | `string` | Template, Required | The ID of the Image Source. |
| `meta` | [`List<Meta26Enum>`](../../doc/models/meta-26-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include23Enum>`](../../doc/models/include-23-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |

## Response Type

[`Task<Models.V1ImagesSourcesResponse2>`](../../doc/models/v1-images-sources-response-2.md)

## Example Usage

```csharp
string sourceId = "sourceId4";
try
{
    V1ImagesSourcesResponse2 result = await imageSourcesController.GetImageSourceAsync(sourceId);
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


# Update Image Source

Requires the `images-sources-manage` capability.

```csharp
UpdateImageSourceAsync(
    string sourceId,
    Models.V1ImagesSourcesRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sourceId` | `string` | Template, Required | The ID of the Image Source. |
| `body` | [`V1ImagesSourcesRequest1`](../../doc/models/v1-images-sources-request-1.md) | Body, Optional | Parameters for updating an image source. |

## Response Type

[`Task<Models.V1ImagesSourcesResponse1>`](../../doc/models/v1-images-sources-response-1.md)

## Example Usage

```csharp
string sourceId = "sourceId4";
try
{
    V1ImagesSourcesResponse1 result = await imageSourcesController.UpdateImageSourceAsync(sourceId);
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


# Delete Image Source

Requires the `images-sources-manage` capability.

```csharp
DeleteImageSourceAsync(
    string sourceId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sourceId` | `string` | Template, Required | The ID of the Image Source. |

## Response Type

[`Task<Models.V1ImagesSourcesResponse4>`](../../doc/models/v1-images-sources-response-4.md)

## Example Usage

```csharp
string sourceId = "sourceId4";
try
{
    V1ImagesSourcesResponse4 result = await imageSourcesController.DeleteImageSourceAsync(sourceId);
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

