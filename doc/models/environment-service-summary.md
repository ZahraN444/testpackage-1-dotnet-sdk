
# Environment Service Summary

An object containing information about the service containers associated with this container. Each key is the name of a service, one of `discovery`, `vpn`, or `loadbalancer`.

## Structure

`EnvironmentServiceSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Loadbalancer` | [`EnvironmentServiceSummaryLoadbalancer`](../../doc/models/containers/environment-service-summary-loadbalancer.md) | Optional | This is a container for any-of cases. |
| `Discovery` | [`EnvironmentServiceSummaryDiscovery`](../../doc/models/containers/environment-service-summary-discovery.md) | Optional | This is a container for any-of cases. |
| `Vpn` | [`EnvironmentServiceSummaryVpn`](../../doc/models/containers/environment-service-summary-vpn.md) | Optional | This is a container for any-of cases. |
| `Scheduler` | [`EnvironmentServiceSummaryScheduler`](../../doc/models/containers/environment-service-summary-scheduler.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
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
}
```

