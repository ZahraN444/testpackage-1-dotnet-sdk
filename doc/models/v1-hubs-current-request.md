
# V1 Hubs Current Request

## Structure

`V1HubsCurrentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Optional | A name for the hub. |
| `Webhooks` | [`HubWebhooks`](../../doc/models/hub-webhooks.md) | Optional | Hub related webhooks. When supplied, the given webhook will be called with a payload any time one of these events occurs. |

## Example (as JSON)

```json
{
  "name": "name8",
  "webhooks": {
    "server_deployed": "server_deployed2",
    "server_deleted": "server_deleted0"
  }
}
```

