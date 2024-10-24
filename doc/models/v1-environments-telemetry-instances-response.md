
# V1 Environments Telemetry Instances Response

## Structure

`V1EnvironmentsTelemetryInstancesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<InstanceTelemetryPoint>`](../../doc/models/instance-telemetry-point.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "time": "01/30/2021 08:30:00",
      "instances": {
        "key0": 153,
        "key1": 152
      }
    }
  ]
}
```

