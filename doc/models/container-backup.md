
# Container Backup

A Container Backup.

## Structure

`ContainerBackup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `ContainerId` | `string` | Required | The ID of the given container. |
| `InstanceId` | `string` | Required | The ID of the instance the backup belongs to. |
| `Target` | [`ContainerBackupTarget`](../../doc/models/container-backup-target.md) | Required | A target for the given Container Backup. |
| `State` | [`ContainerBackupState`](../../doc/models/container-backup-state.md) | Required | - |
| `Events` | [`BackupEvents`](../../doc/models/backup-events.md) | Required | A collection of timestamps for each event in the backup's lifetime. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "container_id": "container_id6",
  "instance_id": "instance_id0",
  "target": {
    "integration_id": "my-image-source",
    "path": "path6",
    "file_id": "file_id8",
    "size": 106
  },
  "state": {
    "current": "deleting",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00"
  }
}
```

