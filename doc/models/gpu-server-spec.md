
# GPU Server Spec

Information about a given servers GPU resources.

## Structure

`GPUServerSpec`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Count` | `int` | Required | The number of GPUs. |
| `Cores` | `int?` | Optional | The number of cores. |
| `VramGb` | `int?` | Optional | The amount of virtaul RAM for the GPU. |
| `Type` | `string` | Required | The type of the GPU. |
| `Shared` | `bool?` | Optional | A boolean where true represents the GPU is shared. |
| `Extra` | `Dictionary<string, string>` | Optional | Extra information about the GPU if there is any. |

## Example (as JSON)

```json
{
  "count": 160,
  "cores": 242,
  "vram_gb": 34,
  "type": "type6",
  "shared": false,
  "extra": {
    "key0": "extra6"
  }
}
```

