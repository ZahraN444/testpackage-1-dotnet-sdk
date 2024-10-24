
# Local 1

Configuration for settings local to the container filesystem.

## Structure

`Local1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MaxSize` | `string` | Required | The maximum size the volume can grow to. A number followed by a size. `10G` would be 10 gigabytes. |
| `StoragePool` | `bool?` | Optional | A boolean where true signifies using the largest drive over 2TB for the target server. |

## Example (as JSON)

```json
{
  "max_size": "10G",
  "storage_pool": false
}
```

