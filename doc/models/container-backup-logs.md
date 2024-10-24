
# Container Backup Logs

Backup logs for a given container.

## Structure

`ContainerBackupLogs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `ContainerId` | `string` | Required | An identifier for the container. |
| `InstanceId` | `string` | Required | An identifier for the instance. |
| `BackupId` | `string` | Required | An identifier for the backup. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Type` | [`Type11Enum`](../../doc/models/type-11-enum.md) | Required | The type of the backup log. |
| `Log` | `string` | Required | The log. |
| `Error` | [`Error2`](../../doc/models/error-2.md) | Optional | - |
| `Events` | [`BackupLogEvents`](../../doc/models/backup-log-events.md) | Required | A collection of timestamps for each event in the backup log's lifetime. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "container_id": "container_id6",
  "instance_id": "instance_id0",
  "backup_id": "backup_id4",
  "hub_id": "651586fca6078e98982dbd90",
  "type": "restore",
  "log": "log8",
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00"
  },
  "error": {
    "message": "message4",
    "message_internal": "message_internal2",
    "stack": [
      {
        "file": "file4",
        "function": "function0",
        "line": 212
      },
      {
        "file": "file4",
        "function": "function0",
        "line": 212
      }
    ]
  }
}
```

