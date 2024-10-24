
# Stateful 3

Information about additonal configuration settings used when migrating a stateful instance.

## Structure

`Stateful3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CopyVolumes` | `bool` | Required | A boolean where true represents the desire to copy the contents of the volume for a given stateful instance with the migration. |

## Example (as JSON)

```json
{
  "copy_volumes": false
}
```

