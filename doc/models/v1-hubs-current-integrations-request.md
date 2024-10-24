
# V1 Hubs Current Integrations Request

## Structure

`V1HubsCurrentIntegrationsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A new name for the Integration. |
| `Identifier` | `string` | Optional | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Auth` | [`V1HubsCurrentIntegrationsRequestAuth`](../../doc/models/containers/v1-hubs-current-integrations-request-auth.md) | Optional | This is a container for any-of cases. |
| `Extra` | `Dictionary<string, string>` | Optional | Updated key-value pairs associated with the Integration. |

## Example (as JSON)

```json
{
  "name": "name6",
  "identifier": "identifier6",
  "auth": {
    "region": "region2",
    "namespace": "namespace6",
    "api_key": "api_key6",
    "key_id": "key_id2",
    "secret": "secret8"
  },
  "extra": {
    "key0": "extra8",
    "key1": "extra7"
  }
}
```

