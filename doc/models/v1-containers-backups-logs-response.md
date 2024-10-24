
# V1 Containers Backups Logs Response

## Structure

`V1ContainersBackupsLogsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<ContainerBackupLogs>`](../../doc/models/container-backup-logs.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
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
  ]
}
```

