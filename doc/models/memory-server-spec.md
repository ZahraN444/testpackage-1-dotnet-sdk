
# Memory Server Spec

Information about the memory resources of a given server.

## Structure

`MemoryServerSpec`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SizeGb` | `int` | Required | A number that represents the memory resources in GB. |
| `Type` | `string` | Required | The type of the memory resources. |
| `Extra` | `Dictionary<string, string>` | Required | Extra inforamtion about the memory resources. |

## Example (as JSON)

```json
{
  "size_gb": 150,
  "type": "type0",
  "extra": {
    "key0": "extra8",
    "key1": "extra9",
    "key2": "extra0"
  }
}
```

