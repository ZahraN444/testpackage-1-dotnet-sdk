
# Container Volume

Configuration settings for container volumes.

## Structure

`ContainerVolume`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ReadOnly` | `bool` | Required | A boolean where true marks the volume as read only. |
| `Local` | [`Local1`](../../doc/models/local-1.md) | Optional | Configuration for settings local to the container filesystem. |
| `Destination` | `string` | Required | The mountpoint path for the container. |
| `RemoteAccess` | [`RemoteAccess1`](../../doc/models/remote-access-1.md) | Optional | Configuration settings for remotely accessing the container volume. |

## Example (as JSON)

```json
{
  "read_only": false,
  "local": {
    "max_size": "max_size6",
    "storage_pool": false
  },
  "destination": "destination2",
  "remote_access": {
    "enable": false,
    "ips": [
      "ips4",
      "ips5",
      "ips6"
    ],
    "web_hook": "web_hook0",
    "password": {
      "algorithm": "sha512",
      "data": "data4"
    }
  }
}
```

