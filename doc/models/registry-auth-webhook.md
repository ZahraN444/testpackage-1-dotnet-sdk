
# Registry Auth Webhook

Webhook-based authentication to the provided URL. This webhook expects to receive a base-64 string that when decoded is in the format `username:password`

## Structure

`RegistryAuthWebhook`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"webhook"` |
| `Details` | [`Details9`](../../doc/models/details-9.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "webhook",
  "details": {
    "url": "url4"
  }
}
```

