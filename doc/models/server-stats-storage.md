
# Server Stats Storage

Statistics about storage for a given server.

## Structure

`ServerStatsStorage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VolumeGroups` | [`Dictionary<string, VolumeGroups>`](../../doc/models/volume-groups.md) | Required | An array of volume group objects. |
| `Mounts` | [`Dictionary<string, MountedFS>`](../../doc/models/mounted-fs.md) | Required | Records that show information about mounted filesystems where the key is the path to the mount. |

## Example (as JSON)

```json
{
  "volume_groups": {
    "key0": {
      "name": "name8",
      "size": 104,
      "volumes": {
        "key0": {
          "name": "name6",
          "size": 224,
          "data_percent": 206,
          "meta_percent": 96,
          "pool": "pool0"
        },
        "key1": {
          "name": "name6",
          "size": 224,
          "data_percent": 206,
          "meta_percent": 96,
          "pool": "pool0"
        },
        "key2": {
          "name": "name6",
          "size": 224,
          "data_percent": 206,
          "meta_percent": 96,
          "pool": "pool0"
        }
      }
    },
    "key1": {
      "name": "name8",
      "size": 104,
      "volumes": {
        "key0": {
          "name": "name6",
          "size": 224,
          "data_percent": 206,
          "meta_percent": 96,
          "pool": "pool0"
        },
        "key1": {
          "name": "name6",
          "size": 224,
          "data_percent": 206,
          "meta_percent": 96,
          "pool": "pool0"
        },
        "key2": {
          "name": "name6",
          "size": 224,
          "data_percent": 206,
          "meta_percent": 96,
          "pool": "pool0"
        }
      }
    }
  },
  "mounts": {
    "key0": {
      "device": "device8",
      "type": "type8",
      "mountpoint": "mountpoint8",
      "total": 26,
      "free": 68,
      "used": 220
    },
    "key1": {
      "device": "device8",
      "type": "type8",
      "mountpoint": "mountpoint8",
      "total": 26,
      "free": 68,
      "used": 220
    }
  }
}
```

