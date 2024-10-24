
# Restore 1

Configuration settings for restoring from a backup.

## Structure

`Restore1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Command` | `string` | Required | The command to run for restoring from a backup. |
| `Timeout` | `string` | Optional | The time in seconds for the restore to attempt to complete before timing out. |

## Example (as JSON)

```json
{
  "command": "command6",
  "timeout": "timeout8"
}
```

