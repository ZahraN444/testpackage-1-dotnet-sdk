
# Server Shared File Systems

## Structure

`ServerSharedFileSystems`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mounts` | [`Dictionary<string, Mounts>`](../../doc/models/mounts.md) | Optional | - |
| `Directories` | `object` | Optional | An object describing directory identifiers with value {}. |

## Example (as JSON)

```json
{
  "mounts": {
    "key0": {
      "type": "type8",
      "options": "options0",
      "source": "source2"
    }
  },
  "directories": {
    "key0": {
      "key1": "val1",
      "key2": "val2"
    },
    "key1": {
      "key1": "val1",
      "key2": "val2"
    },
    "key2": {
      "key1": "val1",
      "key2": "val2"
    }
  }
}
```

