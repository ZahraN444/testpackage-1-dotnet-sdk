
# V1 Hubs Request

## Structure

`V1HubsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name for the Hub. |
| `Identifier` | `string` | Optional | A human-readable identifier used to refer to a resource, where using the official ID may be inconvenient.<br>The identifier is automatically tokenized from the name/relevant field of the resource if one is not provided. For example, a container named "My Container" will<br>have the identifier of `my-container` and is automatically created by the platform.<br><br>The identifier does not have to be unique. |
| `Webhooks` | [`HubWebhooks`](../../doc/models/hub-webhooks.md) | Optional | Hub related webhooks. When supplied, the given webhook will be called with a payload any time one of these events occurs. |

## Example (as JSON)

```json
{
  "name": "name2",
  "identifier": "identifier0",
  "webhooks": {
    "server_deployed": "server_deployed2",
    "server_deleted": "server_deleted0"
  }
}
```

