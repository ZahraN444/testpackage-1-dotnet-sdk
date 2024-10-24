
# Volume Summary

A summary of relevant volume information.

## Structure

`VolumeSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Hash` | `string` | Required | A unique hash for the given volume. |
| `Config` | [`ContainerVolume`](../../doc/models/container-volume.md) | Required | Configuration settings for container volumes. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hash": "hash8",
  "config": {
    "read_only": false,
    "local": {
      "max_size": "max_size6",
      "storage_pool": false
    },
    "destination": "destination8",
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
}
```

