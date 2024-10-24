
# Match 1

Describes which container and which tagged deployment this record should target.

## Structure

`Match1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Container` | `string` | Required | The identifier of the container in the environment this record should point to. |
| `Tag` | [`Match1Tag`](../../doc/models/containers/match-1-tag.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "container": "container2",
  "tag": "String7"
}
```

