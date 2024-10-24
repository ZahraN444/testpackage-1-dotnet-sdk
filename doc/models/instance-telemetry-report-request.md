
# Instance Telemetry Report Request

A summary of report requests and when they occured.

## Structure

`InstanceTelemetryReportRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `InstanceId` | `string` | Required | The ID of the instance this telemetry reporting pertains to. |
| `Start` | `DateTime` | Required | A timestamp of when the snapshot began. |
| `End` | `DateTime` | Required | A timestamp of when the snapshot ended. |

## Example (as JSON)

```json
{
  "instance_id": "instance_id8",
  "start": "01/30/2021 08:30:00",
  "end": "01/30/2021 08:30:00"
}
```

