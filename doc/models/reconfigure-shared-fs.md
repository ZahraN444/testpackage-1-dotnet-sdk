
# Reconfigure Shared Fs

## Structure

`ReconfigureSharedFs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required, Constant | The action to take.<br>**Default**: `"sharedfs.reconfigure"` |
| `Contents` | [`ServerSharedFileSystems`](../../doc/models/server-shared-file-systems.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "sharedfs.reconfigure",
  "contents": {
    "mounts": {
      "key0": {
        "type": "type8",
        "options": "options0",
        "source": "source2"
      },
      "key1": {
        "type": "type8",
        "options": "options0",
        "source": "source2"
      }
    },
    "directories": {
      "key0": {
        "key1": "val1",
        "key2": "val2"
      }
    }
  }
}
```

