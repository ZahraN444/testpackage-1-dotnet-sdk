
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `XHubId2` | `string` | Defines the scope of the request to a specific Hub. |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BearerAuthCredentials` | [`BearerAuthCredentials`](auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |
| `HubAuthCredentials` | [`HubAuthCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |

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

## Cycle Platform APIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| EnvironmentsController | Gets EnvironmentsController controller. |
| ContainersController | Gets ContainersController controller. |
| ImagesController | Gets ImagesController controller. |
| StacksController | Gets StacksController controller. |
| PipelinesController | Gets PipelinesController controller. |
| DNSController | Gets DNSController controller. |
| InfrastructureController | Gets InfrastructureController controller. |
| ServersController | Gets ServersController controller. |
| SDNController | Gets SDNController controller. |
| InstancesController | Gets InstancesController controller. |
| JobsController | Gets JobsController controller. |
| AccountsController | Gets AccountsController controller. |
| AnnouncementsController | Gets AnnouncementsController controller. |
| BillingController | Gets BillingController controller. |
| HubsController | Gets HubsController controller. |
| SearchController | Gets SearchController controller. |
| ImageSourcesController | Gets ImageSourcesController controller. |
| SecurityController | Gets SecurityController controller. |
| UtilityController | Gets UtilityController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| XHubId2 | Defines the scope of the request to a specific Hub. | `string` |
| Environment | Current API environment. | `Environment` |
| BearerAuthCredentials | Gets the credentials to use with BearerAuth. | [`IBearerAuthCredentials`](auth/oauth-2-bearer-token.md) |
| HubAuthCredentials | Gets the credentials to use with HubAuth. | [`IHubAuthCredentials`](auth/custom-header-signature.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the Cycle Platform APIClient using the values provided for the builder. | `Builder` |

## Cycle Platform APIClient Builder Class

Class to build instances of Cycle Platform APIClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `XHubId2(string xHubId2)` | Defines the scope of the request to a specific Hub. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `BearerAuthCredentials(Action<BearerAuthModel.Builder> action)` | Sets credentials for BearerAuth. | `Builder` |
| `HubAuthCredentials(Action<HubAuthModel.Builder> action)` | Sets credentials for HubAuth. | `Builder` |

