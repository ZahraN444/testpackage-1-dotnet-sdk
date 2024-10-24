
# Webhook Post Step

A pipeline step that will make a POST request to the specified endpoints. The webhook will post the full body of the resource referenced by the step.
For example if you were to reference a step creating a container, you would receive that container object in the post body.
You may also specify a custom body instead.

## Structure

`WebhookPostStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"webhook.post"` |
| `Details` | [`Details57`](../../doc/models/details-57.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "webhook.post",
  "details": {
    "url": "url4",
    "from": "init/image-create",
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
    },
    "body": "body6"
  },
  "identifier": "identifier6",
  "options": {
    "skip": false
  }
}
```

