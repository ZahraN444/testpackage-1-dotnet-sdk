
# Telemetry 1

## Structure

`Telemetry1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Retention` | [`Telemetry1Retention`](../../doc/models/containers/telemetry-1-retention.md) | Optional | This is a container for any-of cases. |
| `Interval` | [`Telemetry1Interval`](../../doc/models/containers/telemetry-1-interval.md) | Optional | This is a container for any-of cases. |
| `WebHook` | `string` | Optional | A URL where Cycle will send telemetry data to. |
| `Disable` | `bool` | Required | - |

## Example (as JSON)

```json
{
  "retention": "String9",
  "interval": "String5",
  "web_hook": "web_hook6",
  "disable": false
}
```

