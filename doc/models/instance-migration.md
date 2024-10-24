
# Instance Migration

Information regarding the migration of an instance, such as the server that the instance came from or the server that the instance was moved to.

## Structure

`InstanceMigration`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `To` | [`InstanceMigrationTo`](../../doc/models/containers/instance-migration-to.md) | Optional | This is a container for any-of cases. |
| `From` | [`InstanceMigrationFrom`](../../doc/models/containers/instance-migration-from.md) | Optional | This is a container for any-of cases. |
| `Started` | `DateTime?` | Optional | A timestamp of when the migration was started. |
| `Completed` | `DateTime?` | Optional | A timestamp of when the migration was completed. |
| `Key` | `string` | Required | A key used by the platform to verify the migration. |
| `CopyVolumes` | `bool` | Required | A boolean where true represents the volumes for the instance should be copied to the new server as well. |

## Example (as JSON)

```json
{
  "started": "01/30/2021 08:30:00",
  "completed": "01/30/2021 08:30:00",
  "key": "key0",
  "copy_volumes": false,
  "to": {
    "instance_id": "instance_id0",
    "server_id": "server_id0"
  },
  "from": {
    "instance_id": "instance_id0",
    "server_id": "server_id0"
  }
}
```

