
# Backup 1

Configuration settings for each backup.

## Structure

`Backup1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Command` | `string` | Required | The command to run for the backup. |
| `Timeout` | [`Backup1Timeout`](../../doc/models/containers/backup-1-timeout.md) | Optional | This is a container for any-of cases. |
| `CronString` | `string` | Optional | A cron string that configures how often the backup will run. |

## Example (as JSON)

```json
{
  "command": "command6",
  "timeout": "String9",
  "cron_string": "cron_string6"
}
```

