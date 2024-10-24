
# Environment Summary

Contains useful and relevant data/statistics for an environment that would otherwise be several separate API calls.

## Structure

`EnvironmentSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `State` | [`EnvironmentState`](../../doc/models/environment-state.md) | Required | - |
| `Services` | [`EnvironmentServiceSummary`](../../doc/models/environment-service-summary.md) | Required | An object containing information about the service containers associated with this container. Each key is the name of a service, one of `discovery`, `vpn`, or `loadbalancer`. |
| `Stats` | [`EnvironmentSummaryStats`](../../doc/models/environment-summary-stats.md) | Required | Statistics about the containers and instances associated with this environment. |

## Example (as JSON)

```json
{
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
```

