
# Custom Header Signature



Documentation for accessing and setting credentials for hubAuth.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| X-Hub-Id | `string` | Defines the scope of the request to a specific Hub. | `XHubId` | `XHubId` |



**Note:** Auth credentials can be set using `HubAuthCredentials` in the client builder and accessed through `HubAuthCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
CyclePlatformAPIClient client = new CyclePlatformAPIClient.Builder()
    .HubAuthCredentials(
        new HubAuthModel.Builder(
            "X-Hub-Id"
        )
        .Build())
    .Build();
```


