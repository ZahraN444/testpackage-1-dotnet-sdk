
# Hub Webhooks

Hub related webhooks. When supplied, the given webhook will be called with a payload any time one of these events occurs.

## Structure

`HubWebhooks`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServerDeployed` | `string` | Required | A webhook that is called any time a server is deployed to this hub. The payload will be a `Server` object. |
| `ServerDeleted` | `string` | Required | A webhook that is called any time a server in this hub is deleted. The payload will be a `Server` object. |

## Example (as JSON)

```json
{
  "server_deployed": "server_deployed8",
  "server_deleted": "server_deleted6"
}
```

