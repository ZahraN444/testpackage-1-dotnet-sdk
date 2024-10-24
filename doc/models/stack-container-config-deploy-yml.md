
# Stack Container Config Deploy Yml

## Structure

`StackContainerConfigDeployYml`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Instances` | `int` | Required | - |
| `Strategy` | [`DeploymentStrategyNameEnum?`](../../doc/models/deployment-strategy-name-enum.md) | Optional | - |
| `Stateful` | [`Stateful`](../../doc/models/stateful.md) | Optional | - |
| `Constraints` | [`Constraints`](../../doc/models/constraints.md) | Optional | - |
| `Shutdown` | [`Shutdown`](../../doc/models/shutdown.md) | Optional | - |
| `Startup` | [`Startup`](../../doc/models/startup.md) | Optional | - |
| `Update` | [`Update`](../../doc/models/update.md) | Optional | Configurations for container updates. |
| `Restart` | [`Restart`](../../doc/models/restart.md) | Optional | - |
| `HealthCheck` | [`HealthCheck`](../../doc/models/health-check.md) | Optional | - |
| `Telemetry` | [`Telemetry1`](../../doc/models/telemetry-1.md) | Optional | - |

## Example (as JSON)

```json
{
  "instances": 206,
  "strategy": "resource-density",
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
    ],
    "containers": [
      "containers5"
    ]
  },
  "shutdown": {
    "graceful_timeout": "String7",
    "signals": [
      "signals2",
      "signals3"
    ]
  },
  "startup": {
    "delay": "String3"
  }
}
```

