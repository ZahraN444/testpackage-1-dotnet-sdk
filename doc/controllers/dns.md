# DNS

Cycle provides a full suite of DNS tooling.  Set up everything from a DNS Zone, record, certificate, and more.

```csharp
DNSController dNSController = client.DNSController;
```

## Class Name

`DNSController`

## Methods

* [Get DNS Zones](../../doc/controllers/dns.md#get-dns-zones)
* [Create DNS Zone](../../doc/controllers/dns.md#create-dns-zone)
* [Get DNS Zone](../../doc/controllers/dns.md#get-dns-zone)
* [Update DNS Zone](../../doc/controllers/dns.md#update-dns-zone)
* [Delete DNS Zone](../../doc/controllers/dns.md#delete-dns-zone)
* [Create DNS Zone Job](../../doc/controllers/dns.md#create-dns-zone-job)
* [Get DNS Zone Records](../../doc/controllers/dns.md#get-dns-zone-records)
* [Create DNS Zone Record](../../doc/controllers/dns.md#create-dns-zone-record)
* [Update DNS Zone Record](../../doc/controllers/dns.md#update-dns-zone-record)
* [Delete DNS Zone Record](../../doc/controllers/dns.md#delete-dns-zone-record)
* [Create DNS Zone Record Job](../../doc/controllers/dns.md#create-dns-zone-record-job)
* [Get TLS Generation Attempts](../../doc/controllers/dns.md#get-tls-generation-attempts)
* [Lookup TLS Certificate](../../doc/controllers/dns.md#lookup-tls-certificate)


# Get DNS Zones

Requires the `dns-view` capability.

```csharp
GetDNSZonesAsync(
    List<Models.Include12Enum> include = null,
    Models.Filter12 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `include` | [`List<Include12Enum>`](../../doc/models/include-12-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter12`](../../doc/models/filter-12.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1DnsZonesResponse>`](../../doc/models/v1-dns-zones-response.md)

## Example Usage

```csharp
try
{
    V1DnsZonesResponse result = await dNSController.GetDNSZonesAsync();
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


# Create DNS Zone

Requires the `dns-manage` capability.

```csharp
CreateDNSZoneAsync(
    Models.V1DnsZonesRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`V1DnsZonesRequest`](../../doc/models/v1-dns-zones-request.md) | Body, Optional | Parameters for creating a new DNS Zone. |

## Response Type

[`Task<Models.V1DnsZonesResponse1>`](../../doc/models/v1-dns-zones-response-1.md)

## Example Usage

```csharp
try
{
    V1DnsZonesResponse1 result = await dNSController.CreateDNSZoneAsync();
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


# Get DNS Zone

Requires the `dns-view` capability.

```csharp
GetDNSZoneAsync(
    string zoneId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `zoneId` | `string` | Template, Required | The ID of the zone. |

## Response Type

[`Task<Models.V1DnsZonesResponse1>`](../../doc/models/v1-dns-zones-response-1.md)

## Example Usage

```csharp
string zoneId = "zoneId8";
try
{
    V1DnsZonesResponse1 result = await dNSController.GetDNSZoneAsync(zoneId);
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


# Update DNS Zone

Requires the `dns-manage` capability.

```csharp
UpdateDNSZoneAsync(
    string zoneId,
    List<Models.Include12Enum> include = null,
    Models.V1DnsZonesRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `zoneId` | `string` | Template, Required | The ID of the zone. |
| `include` | [`List<Include12Enum>`](../../doc/models/include-12-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `body` | [`V1DnsZonesRequest1`](../../doc/models/v1-dns-zones-request-1.md) | Body, Optional | Parameters for updating a DNS Zone. |

## Response Type

[`Task<Models.DNSZoneUpdateResponse>`](../../doc/models/dns-zone-update-response.md)

## Example Usage

```csharp
string zoneId = "zoneId8";
try
{
    DNSZoneUpdateResponse result = await dNSController.UpdateDNSZoneAsync(zoneId);
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


# Delete DNS Zone

Requires the `dns-manage` capability.

```csharp
DeleteDNSZoneAsync(
    string zoneId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `zoneId` | `string` | Template, Required | The ID of the zone. |

## Response Type

[`Task<Models.V1DnsZonesResponse3>`](../../doc/models/v1-dns-zones-response-3.md)

## Example Usage

```csharp
string zoneId = "zoneId8";
try
{
    V1DnsZonesResponse3 result = await dNSController.DeleteDNSZoneAsync(zoneId);
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


# Create DNS Zone Job

Used to perform different actions on a given DNS zone.

Requires the `dns-manage` capability.

```csharp
CreateDNSZoneJobAsync(
    string zoneId,
    Models.V1DnsZonesTasksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `zoneId` | `string` | Template, Required | The ID of the zone. |
| `body` | [`V1DnsZonesTasksRequest`](../../doc/models/v1-dns-zones-tasks-request.md) | Body, Optional | Parameters for creating a new DNS zone job. |

## Response Type

[`Task<Models.V1DnsZonesTasksResponse>`](../../doc/models/v1-dns-zones-tasks-response.md)

## Example Usage

```csharp
string zoneId = "zoneId8";
V1DnsZonesTasksRequest body = new V1DnsZonesTasksRequest
{
    Action = "verify",
};

try
{
    V1DnsZonesTasksResponse result = await dNSController.CreateDNSZoneJobAsync(
        zoneId,
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


# Get DNS Zone Records

Requires the `dns-view` capability.

```csharp
GetDNSZoneRecordsAsync(
    string zoneId,
    List<Models.Include14Enum> include = null,
    Models.Filter13 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `zoneId` | `string` | Template, Required | The ID of the zone. |
| `include` | [`List<Include14Enum>`](../../doc/models/include-14-enum.md) | Query, Optional | A comma separated list of include values. Included resources will show up under the root document's `include` field, with the key being the id of the included resource. In the case of applying an include to a collection of resources, if two resources share the same include, it will only appear once in the return. |
| `filter` | [`Filter13`](../../doc/models/filter-13.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.DNSZoneRecordListReturn>`](../../doc/models/dns-zone-record-list-return.md)

## Example Usage

```csharp
string zoneId = "zoneId8";
try
{
    DNSZoneRecordListReturn result = await dNSController.GetDNSZoneRecordsAsync(zoneId);
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


# Create DNS Zone Record

Requires the `dns-manage` capability.

```csharp
CreateDNSZoneRecordAsync(
    string zoneId,
    Models.V1DnsZonesRecordsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `zoneId` | `string` | Template, Required | The ID of the Zone. |
| `body` | [`V1DnsZonesRecordsRequest`](../../doc/models/v1-dns-zones-records-request.md) | Body, Optional | Parameters for creating a new DNS Zone Record. |

## Response Type

[`Task<Models.DNSZoneCreateResponse>`](../../doc/models/dns-zone-create-response.md)

## Example Usage

```csharp
string zoneId = "zoneId8";
try
{
    DNSZoneCreateResponse result = await dNSController.CreateDNSZoneRecordAsync(zoneId);
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


# Update DNS Zone Record

Requires the `dns-manage` capability.

```csharp
UpdateDNSZoneRecordAsync(
    string zoneId,
    string recordId,
    Models.V1DnsZonesRecordsRequest1 body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `zoneId` | `string` | Template, Required | The ID of the Zone. |
| `recordId` | `string` | Template, Required | The ID of the record. |
| `body` | [`V1DnsZonesRecordsRequest1`](../../doc/models/v1-dns-zones-records-request-1.md) | Body, Optional | Parameters for updating a DNS Zone Record. The name value cannot be updated and is omitted from the properties. |

## Response Type

[`Task<Models.V1DnsZonesRecordsResponse>`](../../doc/models/v1-dns-zones-records-response.md)

## Example Usage

```csharp
string zoneId = "zoneId8";
string recordId = "recordId8";
try
{
    V1DnsZonesRecordsResponse result = await dNSController.UpdateDNSZoneRecordAsync(
        zoneId,
        recordId
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


# Delete DNS Zone Record

Requires the `dns-manage` capability.

```csharp
DeleteDNSZoneRecordAsync(
    string zoneId,
    string recordId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `zoneId` | `string` | Template, Required | The ID of the Zone. |
| `recordId` | `string` | Template, Required | The ID of the DNS Zone Record. |

## Response Type

[`Task<Models.V1DnsZonesRecordsResponse1>`](../../doc/models/v1-dns-zones-records-response-1.md)

## Example Usage

```csharp
string zoneId = "zoneId8";
string recordId = "recordId8";
try
{
    V1DnsZonesRecordsResponse1 result = await dNSController.DeleteDNSZoneRecordAsync(
        zoneId,
        recordId
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


# Create DNS Zone Record Job

Used to perform different actions on a given DNS Zone record.

Requires the `dns-manage` capability.

```csharp
CreateDNSZoneRecordJobAsync(
    string zoneId,
    string recordId,
    Models.V1DnsZonesRecordsTasksRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `zoneId` | `string` | Template, Required | The ID of the zone. |
| `recordId` | `string` | Template, Required | The ID of the record. |
| `body` | [`V1DnsZonesRecordsTasksRequest`](../../doc/models/v1-dns-zones-records-tasks-request.md) | Body, Optional | Parameters for creating a new DNS Zone Record Job. |

## Response Type

[`Task<Models.V1DnsZonesRecordsTasksResponse>`](../../doc/models/v1-dns-zones-records-tasks-response.md)

## Example Usage

```csharp
string zoneId = "zoneId8";
string recordId = "recordId8";
V1DnsZonesRecordsTasksRequest body = new V1DnsZonesRecordsTasksRequest
{
    Action = "generateCert",
};

try
{
    V1DnsZonesRecordsTasksResponse result = await dNSController.CreateDNSZoneRecordJobAsync(
        zoneId,
        recordId,
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


# Get TLS Generation Attempts

Requires the `dns-view` capability.

```csharp
GetTLSGenerationAttemptsAsync(
    Models.Filter14 filter = null,
    List<string> sort = null,
    Models.Page page = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `filter` | [`Filter14`](../../doc/models/filter-14.md) | Query, Optional | ## Filter Field<br><br>The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for. |
| `sort` | `List<string>` | Query, Optional | An array of sort values. To sort descending, put a `-` in front of the value, e.g. `-id`. |
| `page` | [`Page`](../../doc/models/page.md) | Query, Optional | In a list return, the data associated with the page number and size returned. 20 results per page, page 2 would be `page[size]=20&page[number]=2` |

## Response Type

[`Task<Models.V1DnsTlsAttemptsResponse>`](../../doc/models/v1-dns-tls-attempts-response.md)

## Example Usage

```csharp
try
{
    V1DnsTlsAttemptsResponse result = await dNSController.GetTLSGenerationAttemptsAsync();
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


# Lookup TLS Certificate

Lookup and retrieve a TLS certificate bundle for a specified domain.

Requires the `dns-view` capability.

```csharp
LookupTLSCertificateAsync(
    string domain,
    bool? wildcard = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `domain` | `string` | Query, Required | The domain to lookup. |
| `wildcard` | `bool?` | Query, Optional | Whether or not to lookup a *. wildcard certificate that would be applicable for this domain. For example, if you are looking for a certificate for x.test.com, setting this to true will identify a *.test.com certificate that would also be applicable. |

## Response Type

[`Task<Models.V1DnsTlsCertificatesLookupResponse>`](../../doc/models/v1-dns-tls-certificates-lookup-response.md)

## Example Usage

```csharp
string domain = "domain6";
try
{
    V1DnsTlsCertificatesLookupResponse result = await dNSController.LookupTLSCertificateAsync(domain);
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

