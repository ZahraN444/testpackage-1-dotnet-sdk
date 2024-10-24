
# V1 Infrastructure Auto Scale Groups Request

## Structure

`V1InfrastructureAutoScaleGroupsRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Identifier` | `string` | Required | - |
| `Cluster` | `string` | Required | - |
| `Scale` | [`AutoScaleGroupScale`](../../doc/models/auto-scale-group-scale.md) | Required | - |
| `Infrastructure` | [`AutoScaleGroupInfrastructure`](../../doc/models/auto-scale-group-infrastructure.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name4",
  "identifier": "identifier8",
  "cluster": "cluster0",
  "scale": {
    "down": {
      "min_ttl": "min_ttl2",
      "inactivity_period": "inactivity_period2",
      "method": "fifo"
    },
    "up": {
      "maximum": 194
    }
  },
  "infrastructure": {
    "models": [
      {
        "provider": "provider4",
        "integration_id": "651586fca6078e98982dbd90",
        "model_id": "model_id4",
        "priority": 54,
        "locations": [
          {
            "id": "id8",
            "availability_zones": [
              "availability_zones5",
              "availability_zones6",
              "availability_zones7"
            ]
          }
        ]
      }
    ]
  }
}
```

