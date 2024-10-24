
# Webhook Get Step

A pipeline step that will make a GET request to the specified endpoint.

## Structure

`WebhookGetStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"webhook.get"` |
| `Details` | [`Details58`](../../doc/models/details-58.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "webhook.get",
  "details": {
    "url": "url4",
    "headers": {
      "key0": "headers3"
    },
    "options": {
      "max_attempts": 166,
      "interval": "String9",
      "fail_on": {
        "not": false,
        "http_codes": [
          92,
          93,
          94
        ]
      },
      "retry_on": {
        "not": false,
        "http_codes": [
          52,
          53
        ]
      }
    }
  },
  "identifier": "identifier2",
  "options": {
    "skip": false
  }
}
```

