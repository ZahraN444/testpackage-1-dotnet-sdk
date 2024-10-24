
# Migration

## Structure

`Migration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `To` | [`MigrationTo`](../../doc/models/containers/migration-to.md) | Optional | This is a container for any-of cases. |
| `From` | [`MigrationFrom`](../../doc/models/containers/migration-from.md) | Optional | This is a container for any-of cases. |
| `Started` | `DateTime?` | Optional | A timestamp of when the migration was started. |
| `Completed` | `DateTime?` | Optional | A timestamp of when the migration was completed. |
| `Key` | `string` | Optional | A key used by the platform to verify the migration. |
| `CopyVolumes` | `bool?` | Optional | A boolean where true represents the volumes for the instance should be copied to the new server as well. |

## Example (as JSON)

```json
{
  "started": "01/30/2021 08:30:00",
  "completed": "01/30/2021 08:30:00",
  "to": {
    "instance_id": "instance_id0",
    "server_id": "server_id0"
  },
  "from": {
    "instance_id": "instance_id0",
    "server_id": "server_id0"
  },
  "key": "key2"
}
```

