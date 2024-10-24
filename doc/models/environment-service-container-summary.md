
# Environment Service Container Summary

An object containing information about a service container associated with this environment.

## Structure

`EnvironmentServiceContainerSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool` | Required | Whether or not the service is enabled. |
| `ContainerId` | [`EnvironmentServiceContainerSummaryContainerId`](../../doc/models/containers/environment-service-container-summary-container-id.md) | Optional | This is a container for any-of cases. |
| `State` | [`ContainerState`](../../doc/models/container-state.md) | Required | - |
| `HighAvailability` | `bool` | Required | Whether or not the service is deployed in high availability |
| `AutoUpdate` | `bool?` | Optional | Whether or not the service will be automatically updated as new versions are released. Otherwise, the service will need to be restarted manually. |

## Example (as JSON)

```json
{
  "enable": false,
  "state": {
    "current": "deleting",
    "changed": "01/30/2021 08:30:00",
    "desired": "stopping",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "high_availability": false,
  "container_id": "String3",
  "auto_update": false
}
```

