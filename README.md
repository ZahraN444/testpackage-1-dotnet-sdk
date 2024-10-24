
# Getting Started with Cycle Platform API

## Introduction

The Cycle Platform API is a [REST-based](http://en.wikipedia.org/wiki/Representational_state_transfer), resource-oriented API
designed to be easy to use and understand. Using this API, you are able to fully interact with the Cycle Platform.

All API responses return JSON, including errors. There is also support for cross-origin resource sharing, so this API can be used
in a client-side web application as well.

### Auth Basics

Every API request much have an accompanying API key in the Authorization header. For more informaiton on generating an API key head over to the [Portal Docs](https://docs.cycle.io/reference/hubs/API-access/api-key-generate).

Your API key should never be made publicly available, published to a public repository, or used on a client side
web app. If you would like to use the API from a web app, you should create a thin-client service that acts as a passthrough for
your API requests.

### The Root Document

Every response follows the same structure, known as the root document. The main data structure, known as a
resource, is nested under a data field. If you request a collection of resources, the
data field will be an array of those resources. If you request a single resource, the data field will be
equal to that resource.

If there is an error, the error field will be present, and the data field will be present and null.

The root resource. If fetching a collection, this will be an array of resource objects.

Includes fields - the key will be the name of the included item passed. All values of include fields
will be a full resource structure. (i.e. including environments will embed full environment objects by ID)

Meta Fields - the key will be equal to the name of the meta field provided. Values of meta
fields will vary based on the resource. These values are injected into the data object(s).

### Scope

In order to fetch resources that are part of a hub (containers, environments, etc.), you will need to pass an
X-Hub-ID header. When fetching collections of resources, this will limit the response to contain only resources from
the specified hub. Most requests require this header.

### Queries

When trying to gather more complete or specific data you can use query parameters to supplement the normal return (metas,
includes) and you can also add specificity to the format and the order (sort, filter). It's worth understanding that
sort & filter should only be used on collections.

**Sort** - An array of sort values. To sort descending, put a `-`n front of the value, i.e. `-id`.

**Include** - An array of include values. Included resources will show up under the root document's `include` field, with the key being the id
of the included resource. In the case of applying an include to a collection of resources, if two resources share the same
include, it will only appear once in the return.

**Meta** - An array of meta values. Meta values will show up under a resource's `meta` field. In the case of applying a meta to a
collection of resources, each resource will have it's own relevant meta data. In some rare cases, meta may not apply to
individual resources, and may appear in the root document. These will be clearly labeled.

**Filter** - The filter field is a key-value object, where the key is what you would like to filter, and the value is the value you're filtering for.

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package Testpackage1SDK --version 1.1.1
```

You can also view the package at:
https://www.nuget.org/packages/Testpackage1SDK/1.1.1

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `XHubId2` | `string` | Defines the scope of the request to a specific Hub. |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BearerAuthCredentials` | [`BearerAuthCredentials`](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |
| `HubAuthCredentials` | [`HubAuthCredentials`](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

```csharp
CyclePlatformAPIClient client = new CyclePlatformAPIClient.Builder()
    .BearerAuthCredentials(
        new BearerAuthModel.Builder(
            "AccessToken"
        )
        .Build())
    .HubAuthCredentials(
        new HubAuthModel.Builder(
            "X-Hub-Id"
        )
        .Build())
    .XHubId2("X-Hub-Id")
    .Build();
```

## Authorization

This API uses the following authentication schemes.

* [`bearerAuth (OAuth 2 Bearer token)`](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/auth/oauth-2-bearer-token.md)
* [`hubAuth (Custom Header Signature)`](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/auth/custom-header-signature.md)

## List of APIs

* [Image Sources](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/image-sources.md)
* [Environments](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/environments.md)
* [Containers](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/containers.md)
* [Images](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/images.md)
* [Stacks](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/stacks.md)
* [Pipelines](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/pipelines.md)
* [DNS](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/dns.md)
* [Infrastructure](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/infrastructure.md)
* [Servers](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/servers.md)
* [SDN](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/sdn.md)
* [Instances](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/instances.md)
* [Jobs](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/jobs.md)
* [Accounts](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/accounts.md)
* [Announcements](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/announcements.md)
* [Billing](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/billing.md)
* [Hubs](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/hubs.md)
* [Search](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/search.md)
* [Security](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/security.md)
* [Utility](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/controllers/utility.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/http-request.md)
* [HttpResponse](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/http-string-response.md)
* [HttpContext](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/ZahraN444/testpackage-1-dotnet-sdk/tree/1.1.1/doc/api-exception.md)

