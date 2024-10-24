
# Data 8

## Structure

`Data8`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ResourceDensity` | [`DeploymentStrategy`](../../doc/models/deployment-strategy.md) | Optional | Information about supported container deployment strategies. |
| `HighAvailability` | [`DeploymentStrategy`](../../doc/models/deployment-strategy.md) | Optional | Information about supported container deployment strategies. |
| `FirstAvailable` | [`DeploymentStrategy`](../../doc/models/deployment-strategy.md) | Optional | Information about supported container deployment strategies. |
| `Node` | [`DeploymentStrategy`](../../doc/models/deployment-strategy.md) | Optional | Information about supported container deployment strategies. |
| `Edge` | [`DeploymentStrategy`](../../doc/models/deployment-strategy.md) | Optional | Information about supported container deployment strategies. |
| `Manual` | [`DeploymentStrategy`](../../doc/models/deployment-strategy.md) | Optional | Information about supported container deployment strategies. |
| `Function` | [`DeploymentStrategy`](../../doc/models/deployment-strategy.md) | Optional | Information about supported container deployment strategies. |

## Example (as JSON)

```json
{
  "resource-density": {
    "name": "name0",
    "disabled": false,
    "description": "description0"
  },
  "high-availability": {
    "name": "name4",
    "disabled": false,
    "description": "description6"
  },
  "first-available": {
    "name": "name0",
    "disabled": false,
    "description": "description0"
  },
  "node": {
    "name": "name2",
    "disabled": false,
    "description": "description2"
  },
  "edge": {
    "name": "name4",
    "disabled": false,
    "description": "description6"
  }
}
```

