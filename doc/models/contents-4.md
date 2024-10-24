
# Contents 4

## Structure

`Contents4`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DestinationServerId` | `string` | Required | The ID of the server being migrated to. |
| `Stateful` | [`Stateful3`](../../doc/models/stateful-3.md) | Optional | Information about additonal configuration settings used when migrating a stateful instance. |

## Example (as JSON)

```json
{
  "destination_server_id": "destination_server_id2",
  "stateful": {
    "copy_volumes": false
  }
}
```

