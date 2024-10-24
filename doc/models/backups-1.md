
# Backups 1

Automated backups configuration for the given container.

## Structure

`Backups1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IntegrationId` | `string` | Optional | Either a resource ID (objectid - i.e. 651586fca6078e98982dbd90) or a resource Identifier (human-readable) |
| `Backup` | [`Backup1`](../../doc/models/backup-1.md) | Required | Configuration settings for each backup. |
| `Restore` | [`Restore1`](../../doc/models/restore-1.md) | Required | Configuration settings for restoring from a backup. |
| `Retention` | [`Backups1Retention`](../../doc/models/containers/backups-1-retention.md) | Required | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "integration_id": "my-image-source",
  "backup": {
    "command": "command4",
    "timeout": "String9",
    "cron_string": "cron_string6"
  },
  "restore": {
    "command": "command8",
    "timeout": "timeout4"
  },
  "retention": "72h45m2s"
}
```

