
# Backups

## Structure

`Backups`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Destination` | `string` | Required | - |
| `Backup` | [`Backup`](../../doc/models/backup.md) | Required | - |
| `Restore` | [`Restore`](../../doc/models/restore.md) | Required | - |
| `Retention` | [`BackupsRetention`](../../doc/models/containers/backups-retention.md) | Required | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "destination": "destination4",
  "backup": {
    "command": "command4",
    "timeout": "72h45m2s",
    "cron_string": "cron_string6"
  },
  "restore": {
    "command": "command8",
    "timeout": "72h45m2s"
  },
  "retention": "72h45m2s"
}
```

