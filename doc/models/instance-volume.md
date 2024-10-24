
# Instance Volume

A container instance volume resource.

## Structure

`InstanceVolume`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Config` | [`ContainerVolume`](../../doc/models/container-volume.md) | Required | Configuration settings for container volumes. |
| `Deployed` | [`DeployedVolume`](../../doc/models/deployed-volume.md) | Required | A deployed volume resource. |
| `Sftp` | [`InstanceVolumeSFTP`](../../doc/models/instance-volume-sftp.md) | Required | Information about connecting to a instance volume over SFTP. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
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
  },
  "deployed": {
    "server_id": "server_id8",
    "container_id": "container_id8",
    "container_volume_id": "container_volume_id0",
    "instance_id": "instance_id8",
    "hash": "hash8",
    "path": "path6",
    "storage": {
      "used": 134,
      "total": 196
    }
  },
  "sftp": {
    "host": "host6",
    "port": 122.72,
    "username": "username8",
    "password": {
      "algorithm": "sha512",
      "data": "data4"
    }
  }
}
```

