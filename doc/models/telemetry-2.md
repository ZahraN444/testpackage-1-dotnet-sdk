
# Telemetry 2

Configuration settings for container telemetery reporting.

## Structure

`Telemetry2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Retention` | `string` | Required | How long telemetry data should be retained. |
| `Interval` | `string` | Required | The duration between samples. |
| `Disable` | `bool` | Required | A boolean where true disables all telemetry reporting for this container. |
| `WebHook` | `string` | Optional | An endpoint to report the telemetry data to. |

## Example (as JSON)

```json
{
  "retention": "72h45m2s",
  "interval": "72h45m2s",
  "disable": false,
  "web_hook": "web_hook0"
}
```

