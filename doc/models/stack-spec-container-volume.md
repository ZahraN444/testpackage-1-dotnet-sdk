
# Stack Spec Container Volume

## Structure

`StackSpecContainerVolume`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Local` | [`Local`](../../doc/models/local.md) | Optional | - |
| `Destination` | `string` | Required | - |
| `ReadOnly` | `bool` | Required | - |
| `RemoteAccess` | [`RemoteAccess`](../../doc/models/remote-access.md) | Optional | - |

## Example (as JSON)

```json
{
  "local": {
    "max_size": "max_size6",
    "storage_pool": false
  },
  "destination": "destination2",
  "read_only": false,
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

