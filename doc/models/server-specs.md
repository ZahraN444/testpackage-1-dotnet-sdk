
# Server Specs

Specs for a given server

## Structure

`ServerSpecs`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cpu` | [`CPUServerSpec`](../../doc/models/cpu-server-spec.md) | Required | Information about the CPU for a given server. |
| `Gpu` | [`GPUServerSpec`](../../doc/models/gpu-server-spec.md) | Required | Information about a given servers GPU resources. |
| `Memory` | [`MemoryServerSpec`](../../doc/models/memory-server-spec.md) | Required | Information about the memory resources of a given server. |
| `Storage` | [`List<StorageServerSpec>`](../../doc/models/storage-server-spec.md) | Required | - |
| `Network` | [`List<NetworkServerSpec>`](../../doc/models/network-server-spec.md) | Required | - |
| `Features` | [`FeaturesServerSpec`](../../doc/models/features-server-spec.md) | Required | The spec for server features. |

## Example (as JSON)

```json
{
  "cpu": {
    "count": 118,
    "cores": 8,
    "threads": 196,
    "type": "type6",
    "shared": false,
    "extra": {
      "key0": "extra8",
      "key1": "extra7"
    }
  },
  "gpu": {
    "count": 80,
    "cores": 66,
    "vram_gb": 46,
    "type": "type8",
    "shared": false,
    "extra": {
      "key0": "extra4",
      "key1": "extra3"
    }
  },
  "memory": {
    "size_gb": 146,
    "type": "type0",
    "extra": {
      "key0": "extra4"
    }
  },
  "storage": [
    {
      "count": 246,
      "size_gb": 62,
      "type": "type2",
      "extra": {
        "key0": "extra0",
        "key1": "extra1",
        "key2": "extra2"
      }
    }
  ],
  "network": [
    {
      "count": 94,
      "scope": "public",
      "throughput": 184,
      "type": "type6"
    }
  ],
  "features": {
    "raid": "raid2",
    "aws": {
      "ena_support": false,
      "ebs_optimized": false
    }
  }
}
```

