
# Create Auto Scale Group Response

## Structure

`CreateAutoScaleGroupResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`AutoScaleGroup`](../../doc/models/auto-scale-group.md) | Required | - |

## Example (as JSON)

```json
{
  "data": {
    "id": "id0",
    "name": "name0",
    "identifier": "identifier8",
    "creator": {
      "id": "651586fca6078e98982dbd90",
      "type": "employee"
    },
    "hub_id": "hub_id2",
    "cluster": "cluster6",
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
}
```

