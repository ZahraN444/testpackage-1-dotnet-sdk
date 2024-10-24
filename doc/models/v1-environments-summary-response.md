
# V1 Environments Summary Response

## Structure

`V1EnvironmentsSummaryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`EnvironmentSummary`](../../doc/models/environment-summary.md) | Required | Contains useful and relevant data/statistics for an environment that would otherwise be several separate API calls. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "state": {
      "current": "cloning",
      "changed": "01/30/2021 08:30:00",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "services": {
      "loadbalancer": {
        "enable": false,
        "container_id": "String3",
        "state": {
          "current": "deleting",
          "desired": "stopping",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "high_availability": false,
        "auto_update": false
      },
      "discovery": {
        "enable": false,
        "container_id": "String3",
        "state": {
          "current": "deleting",
          "desired": "stopping",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "high_availability": false,
        "auto_update": false
      },
      "vpn": {
        "enable": false,
        "container_id": "String3",
        "state": {
          "current": "deleting",
          "desired": "stopping",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "high_availability": false,
        "auto_update": false
      },
      "scheduler": {
        "enable": false,
        "container_id": "String3",
        "state": {
          "current": "deleting",
          "desired": "stopping",
          "changed": "2016-03-13T12:52:32.123Z",
          "error": {
            "message": "message4",
            "time": "2016-03-13T12:52:32.123Z"
          }
        },
        "high_availability": false,
        "auto_update": false
      }
    },
    "stats": {
      "containers": {
        "state": {
          "new": 0,
          "starting": 0,
          "running": 5,
          "stopping": 0,
          "deleting": 0,
          "deleted": 0
        },
        "total": 5,
        "available": 5
      },
      "instances": {
        "state": {
          "new": 0,
          "starting": 0,
          "running": 5,
          "stopping": 0,
          "deleting": 0,
          "deleted": 0
        },
        "total": 5,
        "available": 5
      }
    }
  }
}
```

