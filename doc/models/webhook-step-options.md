
# Webhook Step Options

Options for configuring webhook pipeline steps.

## Structure

`WebhookStepOptions`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MaxAttempts` | `int?` | Optional | - |
| `Interval` | [`WebhookStepOptionsInterval`](../../doc/models/containers/webhook-step-options-interval.md) | Optional | This is a container for any-of cases. |
| `FailOn` | [`FailOn`](../../doc/models/fail-on.md) | Optional | - |
| `RetryOn` | [`RetryOn`](../../doc/models/retry-on.md) | Optional | - |

## Example (as JSON)

```json
{
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
```

