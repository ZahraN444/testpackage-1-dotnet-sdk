
# Auto Scale Group

## Structure

`AutoScaleGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | - |
| `Name` | `string` | Required | - |
| `Identifier` | `string` | Required | - |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `HubId` | `string` | Required | - |
| `Cluster` | `string` | Required | - |
| `Scale` | [`AutoScaleGroupScale`](../../doc/models/auto-scale-group-scale.md) | Optional | - |
| `Infrastructure` | [`AutoScaleGroupInfrastructure`](../../doc/models/auto-scale-group-infrastructure.md) | Required | - |
| `State` | [`AutoScaleGroupState`](../../doc/models/auto-scale-group-state.md) | Required | - |
| `Events` | [`AutoScaleGroupEvents`](../../doc/models/auto-scale-group-events.md) | Required | A collection of timestamps for each event in the auto-scale group's lifetime. |

## Example (as JSON)

```json
{
  "id": "id8",
  "name": "name8",
  "identifier": "identifier4",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "hub_id": "hub_id0",
  "cluster": "cluster4",
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
  },
  "state": {
    "current": "deleting",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00",
    "last_sync": "01/30/2021 08:30:00"
  },
  "scale": {
    "down": {
      "min_ttl": "min_ttl2",
      "inactivity_period": "inactivity_period2",
      "method": "fifo"
    },
    "up": {
      "maximum": 194
    }
  }
}
```

