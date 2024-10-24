
# Restart

## Structure

`Restart`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Condition` | [`ConditionEnum`](../../doc/models/condition-enum.md) | Required | - |
| `Delay` | `string` | Required | How long the platform will wait before trying to restart the container. |
| `MaxAttempts` | `int` | Required | - |
| `Notify` | [`Notify`](../../doc/models/notify.md) | Optional | - |

## Example (as JSON)

```json
{
  "condition": "never",
  "delay": "72h45m2s",
  "max_attempts": 12,
  "notify": {
    "emails": [
      "emails9",
      "emails0",
      "emails1"
    ],
    "web_hook": "web_hook0"
  }
}
```

