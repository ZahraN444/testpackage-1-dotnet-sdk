
# Health Check

## Structure

`HealthCheck`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Command` | `string` | Required | The command to run as your health check |
| `Retries` | `int` | Required | The number of times to retry the command before marking an instance unhealthy |
| `Interval` | `string` | Required | How long to wait between running health checks. |
| `Timeout` | `string` | Required | How long before a health check attempt times out. |
| `Restart` | `bool` | Required | A boolean where true represents the desire for the container to restart if any instance is unhealthy. |
| `Delay` | [`HealthCheckDelay`](../../doc/models/containers/health-check-delay.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "command": "/bin/sh healthcheck.sh",
  "retries": 154,
  "interval": "72h45m2s",
  "timeout": "72h45m2s",
  "restart": false,
  "delay": "String1"
}
```

