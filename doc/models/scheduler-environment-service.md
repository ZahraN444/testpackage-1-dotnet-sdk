
# Scheduler Environment Service

Information about the environments scheduler service. The scheduler is used by containers with a function deployment strategy to route requests to the correct instances.

## Structure

`SchedulerEnvironmentService`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool` | Required | Whether or not the scheduler service is enabled. |
| `ContainerId` | `string` | Required | The ID of the scheduler service container. |
| `HighAvailability` | `bool?` | Optional | A boolean representing if the scheduler service container is set to high availability. mode or not. As of Jan 2024, this will always be false because HA is not availiable for the scheduler service. |
| `AutoUpdate` | `bool?` | Optional | A boolean where `true` represents the desire to automatically update the environment scheduler service. |
| `Config` | [`SchedulerEnvironmentServiceConfig`](../../doc/models/containers/scheduler-environment-service-config.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "enable": false,
  "container_id": "container_id0",
  "high_availability": false,
  "auto_update": false,
  "config": {
    "public": false,
    "access_keys": [
      {
        "name": "name4",
        "secret": "secret0",
        "ips": [
          "ips8"
        ]
      }
    ]
  }
}
```

