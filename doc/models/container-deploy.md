
# Container Deploy

Deployment configuration for the given container.

## Structure

`ContainerDeploy`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Instances` | `int` | Required | The number of initial desired instances for a given container. |
| `Strategy` | [`DeploymentStrategyName1Enum?`](../../doc/models/deployment-strategy-name-1-enum.md) | Optional | The deployment strategy to use when scaling the given container. |
| `Stateful` | [`Stateful1`](../../doc/models/stateful-1.md) | Optional | - |
| `Constraints` | [`Constraints1`](../../doc/models/constraints-1.md) | Optional | Settings that give more granular control over deployment targets and conditions. |
| `Shutdown` | [`Shutdown1`](../../doc/models/shutdown-1.md) | Optional | Configuration for what to do during container shutdown. |
| `Startup` | [`Startup1`](../../doc/models/startup-1.md) | Optional | Configurations for container startup. |
| `Update` | [`Update1`](../../doc/models/update-1.md) | Optional | Configurations for container updates. |
| `Restart` | [`Restart1`](../../doc/models/restart-1.md) | Optional | Configurations for container restart events. |
| `HealthCheck` | [`HealthCheck1`](../../doc/models/health-check-1.md) | Optional | Configuration for determining the health of a container. |
| `Telemetry` | [`Telemetry2`](../../doc/models/telemetry-2.md) | Optional | Configuration settings for container telemetery reporting. |

## Example (as JSON)

```json
{
  "instances": 180,
  "strategy": "high-availability",
  "stateful": {
    "options": {
      "use_base_hostname": false
    }
  },
  "constraints": {
    "node": {
      "tags": {
        "any": [
          "any6",
          "any7"
        ],
        "all": [
          "all9"
        ]
      }
    },
    "secrets": [
      "secrets1",
      "secrets2"
    ]
  },
  "shutdown": {
    "graceful_timeout": "String7",
    "signals": [
      "SIGHUP",
      "SIGQUIT"
    ]
  },
  "startup": {
    "delay": "delay2"
  }
}
```

