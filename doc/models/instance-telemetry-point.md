
# Instance Telemetry Point

A point-in-time snapshot of a count of instances by state.

## Structure

`InstanceTelemetryPoint`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `DateTime` | Required | A timestamp for when the data was collected. |
| `Instances` | `Dictionary<string, int>` | Required | Records for instance state and number of instances in that state. |

## Example (as JSON)

```json
{
  "time": "01/30/2021 08:30:00",
  "instances": {
    "key0": 143,
    "key1": 142
  }
}
```

