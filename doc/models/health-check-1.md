
# Health Check 1

Configuration for determining the health of a container.

## Structure

`HealthCheck1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Command` | `string` | Required | The command that will be run to verify the health of the container. |
| `Retries` | `int` | Required | The number of times the platform will retry the command before marking the container unhealthy. |
| `Delay` | [`HealthCheck1Delay`](../../doc/models/containers/health-check-1-delay.md) | Required | This is a container for any-of cases. |
| `Interval` | `string` | Required | How long to wait between restarts. |
| `Timeout` | `string` | Required | How long before a health check attempt times out. |
| `Restart` | `bool` | Required | A boolean where `true` represents the desire for a container to restart if unhealthy. |

## Example (as JSON)

```json
{
  "command": "command4",
  "retries": 20,
  "delay": "72h45m2s",
  "interval": "72h45m2s",
  "timeout": "72h45m2s",
  "restart": false
}
```

