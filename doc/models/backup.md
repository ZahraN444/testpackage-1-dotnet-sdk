
# Backup

## Structure

`Backup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Command` | `string` | Required | - |
| `Timeout` | [`BackupTimeout`](../../doc/models/containers/backup-timeout.md) | Required | This is a container for any-of cases. |
| `CronString` | `string` | Required | - |

## Example (as JSON)

```json
{
  "command": "command0",
  "timeout": "72h45m2s",
  "cron_string": "cron_string0"
}
```

