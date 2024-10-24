
# Server Constraints

Constraints to apply to the server.

## Structure

`ServerConstraints`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Tags` | `List<string>` | Required | A list of server tags to put on the given server. |
| `Allow` | [`Allow`](../../doc/models/allow.md) | Required | Settings for the server, things that are or are not allowed. |

## Example (as JSON)

```json
{
  "tags": [
    "tags9",
    "tags0",
    "tags1"
  ],
  "allow": {
    "pool": false,
    "services": false,
    "overcommit": false
  }
}
```

