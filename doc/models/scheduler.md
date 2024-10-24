
# Scheduler

## Structure

`Scheduler`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool?` | Optional | Whether or not the scheduler service is enabled. |
| `ContainerId` | `string` | Optional | The ID of the scheduler service container. |
| `HighAvailability` | `bool?` | Optional | A boolean representing if the scheduler service container is set to high availability. mode or not. As of Jan 2024, this will always be false because HA is not availiable for the scheduler service. |
| `AutoUpdate` | `bool?` | Optional | A boolean where `true` represents the desire to automatically update the environment scheduler service. |
| `Config` | [`SchedulerConfig2`](../../doc/models/containers/scheduler-config-2.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "enable": false,
  "container_id": "container_id8",
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

