
# Constraints 2

Server constriants.

## Structure

`Constraints2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Tags` | `List<string>` | Optional | A list of Server tags. |
| `Allow` | [`Allow1`](../../doc/models/allow-1.md) | Optional | Server constraints for the given Server. |

## Example (as JSON)

```json
{
  "tags": [
    "tags1"
  ],
  "allow": {
    "pool": false,
    "services": false,
    "overcommit": false
  }
}
```

