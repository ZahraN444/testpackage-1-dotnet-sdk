# Images

Container images are atomic copies of a filesystem that are built from a file (ex: Dockerfile).

```csharp
ImagesController imagesController = client.ImagesController;
```

## Class Name

`ImagesController`

## Methods

* [Get Images](../../doc/controllers/images.md#get-images)
* [Create Image](../../doc/controllers/images.md#create-image)
* [Get Image](../../doc/controllers/images.md#get-image)
* [Update Image](../../doc/controllers/images.md#update-image)
* [Delete Image](../../doc/controllers/images.md#delete-image)
* [Get Image Build Log](../../doc/controllers/images.md#get-image-build-log)
* [Create Images Job](../../doc/controllers/images.md#create-images-job)
* [Create Image Job](../../doc/controllers/images.md#create-image-job)


# Get Images

Requires the `images-view` capability.

```csharp
GetImagesAsync(
    List<Models.Meta24Enum> meta = null,
    List<Models.Include21Enum> include = null,
    Models.Filter18 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `meta` | [`List<Meta24Enum>`](../../doc/models/meta-24-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include21Enum>`](../../doc/models/include-21-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter18`](../../doc/models/filter-18.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1ImagesResponse>`](../../doc/models/v1-images-response.md)

## Example Usage

```csharp
try
{
    V1ImagesResponse result = await imagesController.GetImagesAsync();
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


# Create Image

Requires the `images-manage` capability.

```csharp
CreateImageAsync(
    Models.V1ImagesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1ImagesRequest`](../../doc/models/v1-images-request.md) | Body, Optional | Parameters for creating a new Image. |

## Response Type

[`Task<Models.V1ImagesResponse1>`](../../doc/models/v1-images-response-1.md)

## Example Usage

```csharp
try
{
    V1ImagesResponse1 result = await imagesController.CreateImageAsync();
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


# Get Image

Requires the `images-view` capability.

```csharp
GetImageAsync(
    string imageId,
    List<Models.Meta24Enum> meta = null,
    List<Models.Include21Enum> include = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `imageId` | `string` | Template, Required | The ID of the image. |
| `meta` | [`List<Meta24Enum>`](../../doc/models/meta-24-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `include` | [`List<Include21Enum>`](../../doc/models/include-21-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1ImagesResponse2>`](../../doc/models/v1-images-response-2.md)

## Example Usage

```csharp
string imageId = "imageId4";
try
{
    V1ImagesResponse2 result = await imagesController.GetImageAsync(imageId);
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


# Update Image

Requires the `images-manage` capability.

```csharp
UpdateImageAsync(
    string imageId,
    Models.V1ImagesRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `imageId` | `string` | Template, Required | The ID of the image. |
| `body` | [`V1ImagesRequest1`](../../doc/models/v1-images-request-1.md) | Body, Optional | Parameters for creating a new image. |

## Response Type

[`Task<Models.V1ImagesResponse1>`](../../doc/models/v1-images-response-1.md)

## Example Usage

```csharp
string imageId = "imageId4";
try
{
    V1ImagesResponse1 result = await imagesController.UpdateImageAsync(imageId);
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


# Delete Image

Requires the `images-manage` capability.

```csharp
DeleteImageAsync(
    string imageId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `imageId` | `string` | Template, Required | The ID of the image. |

## Response Type

[`Task<Models.V1ImagesResponse4>`](../../doc/models/v1-images-response-4.md)

## Example Usage

```csharp
string imageId = "imageId4";
try
{
    V1ImagesResponse4 result = await imagesController.DeleteImageAsync(imageId);
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


# Get Image Build Log

Requires the `images-view` capability.

```csharp
GetImageBuildLogAsync(
    string imageId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `imageId` | `string` | Template, Required | The ID of the Image. |

## Response Type

[`Task<Models.V1ImagesBuildLogResponse>`](../../doc/models/v1-images-build-log-response.md)

## Example Usage

```csharp
string imageId = "imageId4";
try
{
    V1ImagesBuildLogResponse result = await imagesController.GetImageBuildLogAsync(imageId);
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


# Create Images Job

Used to perform different actions on a given image.

Requires the `images-manage` capability.

```csharp
CreateImagesJobAsync(
    Models.V1ImagesTasksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1ImagesTasksRequest`](../../doc/models/v1-images-tasks-request.md) | Body, Optional | Parameters for creating a new Images Job. |

## Response Type

[`Task<Models.V1ImagesTasksResponse>`](../../doc/models/v1-images-tasks-response.md)

## Example Usage

```csharp
V1ImagesTasksRequest body = new V1ImagesTasksRequest
{
    Action = "prune",
    Contents = new Contents12
    {
        SourceIds = new List<string>
        {
            "source_ids1",
            "source_ids0",
            "source_ids9",
        },
    },
};

try
{
    V1ImagesTasksResponse result = await imagesController.CreateImagesJobAsync(body);
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


# Create Image Job

Used to perform different actions on a given Image.

Requires the `images-import` capability.

```csharp
CreateImageJobAsync(
    string imageId,
    Models.V1ImagesTasksRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `imageId` | `string` | Template, Required | The ID of the requested Image. |
| `body` | [`V1ImagesTasksRequest1`](../../doc/models/v1-images-tasks-request-1.md) | Body, Optional | Parameters for creating a new Image job. |

## Response Type

[`Task<Models.V1ImagesTasksResponse>`](../../doc/models/v1-images-tasks-response.md)

## Example Usage

```csharp
string imageId = "imageId4";
V1ImagesTasksRequest1 body = new V1ImagesTasksRequest1
{
    Action = "import",
};

try
{
    V1ImagesTasksResponse result = await imagesController.CreateImageJobAsync(
        imageId,
        body
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

