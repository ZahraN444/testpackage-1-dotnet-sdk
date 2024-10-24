
# Options 30

## Structure

`Options30`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MaxAttempts` | `int?` | Optional | - |
| `Interval` | [`Options30Interval`](../../doc/models/containers/options-30-interval.md) | Optional | This is a container for any-of cases. |
| `FailOn` | [`FailOn`](../../doc/models/fail-on.md) | Optional | - |
| `RetryOn` | [`RetryOn`](../../doc/models/retry-on.md) | Optional | - |

## Example (as JSON)

```json
{
  "max_attempts": 154,
  "interval": "String5",
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

