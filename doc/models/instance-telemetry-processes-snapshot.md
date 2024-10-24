
# Instance Telemetry Processes Snapshot

Process information for a given snapshot.

## Structure

`InstanceTelemetryProcessesSnapshot`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Current` | `double?` | Optional | The current number of running processes in the instance. |
| `Limit` | `double?` | Optional | The maximum number of running processes for the instance. |

## Example (as JSON)

```json
{
  "current": 10.22,
  "limit": 120.8
}
```

