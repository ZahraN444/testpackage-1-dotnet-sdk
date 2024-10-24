# Billing

```csharp
BillingController billingController = client.BillingController;
```

## Class Name

`BillingController`

## Methods

* [Get Orders](../../doc/controllers/billing.md#get-orders)
* [Create Order](../../doc/controllers/billing.md#create-order)
* [Get Billing Order](../../doc/controllers/billing.md#get-billing-order)
* [Update Billing Order](../../doc/controllers/billing.md#update-billing-order)
* [Create Order Job](../../doc/controllers/billing.md#create-order-job)
* [Get Billing Support Plans](../../doc/controllers/billing.md#get-billing-support-plans)
* [Get Billing Tiers](../../doc/controllers/billing.md#get-billing-tiers)
* [Get Billing Methods](../../doc/controllers/billing.md#get-billing-methods)
* [Create Billing Method](../../doc/controllers/billing.md#create-billing-method)
* [Get Billing Method](../../doc/controllers/billing.md#get-billing-method)
* [Update Billing Method](../../doc/controllers/billing.md#update-billing-method)
* [Delete Billing Method](../../doc/controllers/billing.md#delete-billing-method)
* [Get Invoices](../../doc/controllers/billing.md#get-invoices)
* [Get Invoice](../../doc/controllers/billing.md#get-invoice)
* [Create Invoice Job](../../doc/controllers/billing.md#create-invoice-job)
* [Get Billing Services](../../doc/controllers/billing.md#get-billing-services)
* [Get Billing Service](../../doc/controllers/billing.md#get-billing-service)
* [Get Billing Overages](../../doc/controllers/billing.md#get-billing-overages)
* [Get Credits](../../doc/controllers/billing.md#get-credits)
* [Get Credit](../../doc/controllers/billing.md#get-credit)


# Get Orders

Requires the `billing-services-manage` capability.

```csharp
GetOrdersAsync(
    List<string> sort = null,
    object filter = null,
    Models.Page page = null,
    List<Models.Meta2Enum> meta = null,
    List<Models.Include1Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | `object` | Query, Optional | - |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |
| `meta` | [`List<Meta2Enum>`](../../doc/models/meta-2-enum.md) | Query, Optional | - |
| `include` | [`List<Include1Enum>`](../../doc/models/include-1-enum.md) | Query, Optional | - |

## Response Type

[`Task<Models.V1BillingOrdersResponse>`](../../doc/models/v1-billing-orders-response.md)

## Example Usage

```csharp
try
{
    V1BillingOrdersResponse result = await billingController.GetOrdersAsync();
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


# Create Order

Requires the `billing-orders-manage` capability.

```csharp
CreateOrderAsync(
    List<Models.Meta2Enum> meta = null,
    List<Models.Include1Enum> include = null,
    Models.V1BillingOrdersRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `meta` | [`List<Meta2Enum>`](../../doc/models/meta-2-enum.md) | Query, Optional | - |
| `include` | [`List<Include1Enum>`](../../doc/models/include-1-enum.md) | Query, Optional | - |
| `body` | [`V1BillingOrdersRequest`](../../doc/models/v1-billing-orders-request.md) | Body, Optional | Parameters for creating a new order |

## Response Type

[`Task<Models.V1BillingOrdersResponse1>`](../../doc/models/v1-billing-orders-response-1.md)

## Example Usage

```csharp
try
{
    V1BillingOrdersResponse1 result = await billingController.CreateOrderAsync();
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


# Get Billing Order

Requires the `billing-services-manage` capability.

```csharp
GetBillingOrderAsync(
    string orderId,
    List<Models.Meta2Enum> meta = null,
    List<Models.Include1Enum> include = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | The ID of the billing order. |
| `meta` | [`List<Meta2Enum>`](../../doc/models/meta-2-enum.md) | Query, Optional | - |
| `include` | [`List<Include1Enum>`](../../doc/models/include-1-enum.md) | Query, Optional | - |

## Response Type

[`Task<Models.V1BillingOrdersResponse2>`](../../doc/models/v1-billing-orders-response-2.md)

## Example Usage

```csharp
string orderId = "orderId2";
try
{
    V1BillingOrdersResponse2 result = await billingController.GetBillingOrderAsync(orderId);
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


# Update Billing Order

Requires the `billing-services-manage` capability.

```csharp
UpdateBillingOrderAsync(
    string orderId,
    List<Models.Meta2Enum> meta = null,
    List<Models.Include1Enum> include = null,
    Models.V1BillingOrdersRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | The ID of the billing order. |
| `meta` | [`List<Meta2Enum>`](../../doc/models/meta-2-enum.md) | Query, Optional | - |
| `include` | [`List<Include1Enum>`](../../doc/models/include-1-enum.md) | Query, Optional | - |
| `body` | [`V1BillingOrdersRequest`](../../doc/models/v1-billing-orders-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1BillingOrdersResponse2>`](../../doc/models/v1-billing-orders-response-2.md)

## Example Usage

```csharp
string orderId = "orderId2";
try
{
    V1BillingOrdersResponse2 result = await billingController.UpdateBillingOrderAsync(orderId);
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


# Create Order Job

Used to confirm a Billing Order.

Requires the `billing-services-manage` capability.

```csharp
CreateOrderJobAsync(
    string orderId,
    Models.V1BillingOrdersTasksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `orderId` | `string` | Template, Required | The ID of the requested Order |
| `body` | [`V1BillingOrdersTasksRequest`](../../doc/models/v1-billing-orders-tasks-request.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1BillingOrdersTasksResponse>`](../../doc/models/v1-billing-orders-tasks-response.md)

## Example Usage

```csharp
string orderId = "orderId2";
V1BillingOrdersTasksRequest body = new V1BillingOrdersTasksRequest
{
    Action = "confirm",
};

try
{
    V1BillingOrdersTasksResponse result = await billingController.CreateOrderJobAsync(
        orderId,
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


# Get Billing Support Plans

**This endpoint is deprecated.**

```csharp
GetBillingSupportPlansAsync(
    List<string> sort = null,
    object filter = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | `object` | Query, Optional | - |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1BillingPlansSupportResponse>`](../../doc/models/v1-billing-plans-support-response.md)

## Example Usage

```csharp
try
{
    V1BillingPlansSupportResponse result = await billingController.GetBillingSupportPlansAsync();
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


# Get Billing Tiers

Returns list of availiable Billing Tiers.

```csharp
GetBillingTiersAsync()
```

## Response Type

[`Task<Models.V1BillingPlansTiersResponse>`](../../doc/models/v1-billing-plans-tiers-response.md)

## Example Usage

```csharp
try
{
    V1BillingPlansTiersResponse result = await billingController.GetBillingTiersAsync();
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


# Get Billing Methods

Lists the Billing Methods associated with the Hub defined in X-Hub-ID.

Requires the `billing-methods-manage` capability.

```csharp
GetBillingMethodsAsync(
    List<string> sort = null,
    object filter = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | `object` | Query, Optional | - |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1BillingMethodsResponse>`](../../doc/models/v1-billing-methods-response.md)

## Example Usage

```csharp
try
{
    V1BillingMethodsResponse result = await billingController.GetBillingMethodsAsync();
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


# Create Billing Method

Requires the `billing-methods-manage` capability.

```csharp
CreateBillingMethodAsync(
    Models.V1BillingMethodsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1BillingMethodsRequest`](../../doc/models/v1-billing-methods-request.md) | Body, Optional | Parameters for creating a new billing method. |

## Response Type

[`Task<Models.V1BillingMethodsResponse1>`](../../doc/models/v1-billing-methods-response-1.md)

## Example Usage

```csharp
try
{
    V1BillingMethodsResponse1 result = await billingController.CreateBillingMethodAsync();
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


# Get Billing Method

Requires the `billing-methods-manage` capability.

```csharp
GetBillingMethodAsync(
    string methodId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `methodId` | `string` | Template, Required | The ID of the billing method. |

## Response Type

[`Task<Models.V1BillingMethodsResponse1>`](../../doc/models/v1-billing-methods-response-1.md)

## Example Usage

```csharp
string methodId = "methodId6";
try
{
    V1BillingMethodsResponse1 result = await billingController.GetBillingMethodAsync(methodId);
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


# Update Billing Method

Requires the `billing-methods-manage` capability.

```csharp
UpdateBillingMethodAsync(
    string methodId,
    Models.V1BillingMethodsRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `methodId` | `string` | Template, Required | The ID of the billing method. |
| `body` | [`V1BillingMethodsRequest1`](../../doc/models/v1-billing-methods-request-1.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1BillingMethodsResponse1>`](../../doc/models/v1-billing-methods-response-1.md)

## Example Usage

```csharp
string methodId = "methodId6";
try
{
    V1BillingMethodsResponse1 result = await billingController.UpdateBillingMethodAsync(methodId);
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


# Delete Billing Method

Deletes the Billing Method. However, the primary payment method may not be deleted.
Requires the `billing-methods-manage` capability.

```csharp
DeleteBillingMethodAsync(
    string methodId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `methodId` | `string` | Template, Required | The ID of the billing method. |

## Response Type

[`Task<Models.TaskResponse>`](../../doc/models/task-response.md)

## Example Usage

```csharp
string methodId = "methodId6";
try
{
    TaskResponse result = await billingController.DeleteBillingMethodAsync(methodId);
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


# Get Invoices

List the Invoices assoicated with the Hub.

Requires the `billing-invoices-view` capability.

```csharp
GetInvoicesAsync(
    List<string> sort = null,
    Models.Page page = null,
    List<Models.Meta2Enum> meta = null,
    Models.Filter1 filter = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |
| `meta` | [`List<Meta2Enum>`](../../doc/models/meta-2-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |
| `filter` | [`Filter1`](../../doc/models/filter-1.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |

## Response Type

[`Task<Models.V1BillingInvoicesResponse>`](../../doc/models/v1-billing-invoices-response.md)

## Example Usage

```csharp
Filter1 filter = new Filter1
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
    V1BillingInvoicesResponse result = await billingController.GetInvoicesAsync(
        null,
        null,
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


# Get Invoice

Requires the `billing-invoices-view` capability.

```csharp
GetInvoiceAsync(
    string invoiceId,
    List<Models.Meta2Enum> meta = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `invoiceId` | `string` | Template, Required | The ID of the invoice. |
| `meta` | [`List<Meta2Enum>`](../../doc/models/meta-2-enum.md) | Query, Optional | A comma separated list of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to individual resources, and may appear in the root document. These will be clearly labeled. |

## Response Type

[`Task<Models.V1BillingInvoicesResponse1>`](../../doc/models/v1-billing-invoices-response-1.md)

## Example Usage

```csharp
string invoiceId = "invoiceId2";
try
{
    V1BillingInvoicesResponse1 result = await billingController.GetInvoiceAsync(invoiceId);
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


# Create Invoice Job

Creates a new Job on an Invoice. Generally used to make a payment on an Invoice.

Requires the `billing-invoices-pay` capability.

```csharp
CreateInvoiceJobAsync(
    string invoiceId,
    Models.ContainerStartActionTask body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `invoiceId` | `string` | Template, Required | The ID of the invoice. |
| `body` | [`ContainerStartActionTask`](../../doc/models/container-start-action-task.md) | Body, Optional | - |

## Response Type

[`Task<Models.V1BillingInvoicesTasksResponse>`](../../doc/models/v1-billing-invoices-tasks-response.md)

## Example Usage

```csharp
string invoiceId = "invoiceId2";
ContainerStartActionTask body = new ContainerStartActionTask
{
    Action = "start",
};

try
{
    V1BillingInvoicesTasksResponse result = await billingController.CreateInvoiceJobAsync(
        invoiceId,
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


# Get Billing Services

Requries the `billing-services-view` capability.

```csharp
GetBillingServicesAsync(
    List<string> sort = null,
    object filter = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | `object` | Query, Optional | - |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1BillingServicesResponse>`](../../doc/models/v1-billing-services-response.md)

## Example Usage

```csharp
try
{
    V1BillingServicesResponse result = await billingController.GetBillingServicesAsync();
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


# Get Billing Service

Requries the `billing-services-view` capability.

```csharp
GetBillingServiceAsync(
    string servicesId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `servicesId` | `string` | Template, Required | The ID of the Billing Service. |

## Response Type

[`Task<Models.V1BillingServicesResponse1>`](../../doc/models/v1-billing-services-response-1.md)

## Example Usage

```csharp
string servicesId = "servicesId4";
try
{
    V1BillingServicesResponse1 result = await billingController.GetBillingServiceAsync(servicesId);
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


# Get Billing Overages

```csharp
GetBillingOveragesAsync(
    List<string> sort = null,
    object filter = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | `object` | Query, Optional | - |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1BillingServicesOveragesResponse>`](../../doc/models/v1-billing-services-overages-response.md)

## Example Usage

```csharp
try
{
    V1BillingServicesOveragesResponse result = await billingController.GetBillingOveragesAsync();
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


# Get Credits

Lists the Billing Credits associated with the current Hub.

Requires the `billing-credits-view` capability.

```csharp
GetCreditsAsync(
    List<string> sort = null,
    Models.Filter2 filter = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `filter` | [`Filter2`](../../doc/models/filter-2.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1BillingCreditsResponse>`](../../doc/models/v1-billing-credits-response.md)

## Example Usage

```csharp
try
{
    V1BillingCreditsResponse result = await billingController.GetCreditsAsync();
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


# Get Credit

Requires the `billing-credits-view` capability.

```csharp
GetCreditAsync(
    string creditsId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `creditsId` | `string` | Template, Required | The ID for a given credit. |

## Response Type

[`Task<Models.V1BillingCreditsResponse1>`](../../doc/models/v1-billing-credits-response-1.md)

## Example Usage

```csharp
string creditsId = "creditsId8";
try
{
    V1BillingCreditsResponse1 result = await billingController.GetCreditAsync(creditsId);
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

