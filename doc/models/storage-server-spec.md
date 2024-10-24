
# Storage Server Spec

Information about the storage resources for a given server.

## Structure

`StorageServerSpec`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Count` | `int` | Required | The number of storage devices for a given server. |
| `SizeGb` | `int` | Required | The total amount of storage on a given server, in GB. |
| `Type` | `string` | Required | The type of the storage device(s). |
| `Extra` | `Dictionary<string, string>` | Required | Extra information about the storage resources for a given server. |

## Example (as JSON)

```json
{
  "count": 4,
  "size_gb": 48,
  "type": "type8",
  "extra": {
    "key0": "extra4",
    "key1": "extra3",
    "key2": "extra2"
  }
}
```

