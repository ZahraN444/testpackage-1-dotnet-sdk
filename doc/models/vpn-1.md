
# Vpn 1

## Structure

`Vpn1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool?` | Optional | Whether or not the service is enabled. |
| `ContainerId` | [`Vpn1ContainerId`](../../doc/models/containers/vpn-1-container-id.md) | Optional | This is a container for any-of cases. |
| `State` | [`ContainerState`](../../doc/models/container-state.md) | Optional | - |
| `HighAvailability` | `bool?` | Optional | Whether or not the service is deployed in high availability |
| `AutoUpdate` | `bool?` | Optional | Whether or not the service will be automatically updated as new versions are released. Otherwise, the service will need to be restarted manually. |

## Example (as JSON)

```json
{
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
```

