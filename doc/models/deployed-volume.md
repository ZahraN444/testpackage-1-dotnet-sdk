
# Deployed Volume

A deployed volume resource.

## Structure

`DeployedVolume`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ServerId` | `string` | Required | The ID of the server the instance is deployed to. |
| `ContainerId` | `string` | Required | The ID of the container the instance was created from. |
| `ContainerVolumeId` | `string` | Required | The ID for the volume withing the context of the container. |
| `InstanceId` | `string` | Required | The ID for the container instance this volume is attached to. |
| `Hash` | `string` | Required | A hash used as part of the identification mechanisms for the platform and API. |
| `Path` | `string` | Required | The path where the volume is mounted on the instnace filesystem. |
| `Storage` | [`Storage`](../../doc/models/storage.md) | Required | Storage information for the volume. |

## Example (as JSON)

```json
{
  "server_id": "server_id6",
  "container_id": "container_id0",
  "container_volume_id": "container_volume_id8",
  "instance_id": "instance_id6",
  "hash": "hash0",
  "path": "path8",
  "storage": {
    "used": 134,
    "total": 196
  }
}
```

