
# Servers

## Structure

`Servers`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Count` | `double` | Required | - |
| `Providers` | [`Dictionary<string, Providers>`](../../doc/models/providers.md) | Required | - |
| `ServerIds` | `List<string>` | Optional | IDs of all servers in this cluster. |

## Example (as JSON)

```json
{
  "count": 27.88,
  "providers": {
    "key0": {
      "count": 57.74,
      "locations": {
        "key0": 98,
        "key1": 97
      },
      "models": {
        "key0": 178,
        "key1": 179,
        "key2": 180
      },
      "resources": {
        "ram": {
          "total_mb": 88,
          "allocated_mb": 176,
          "used_mb": 246,
          "provisioned_mb": 52
        },
        "cpu": {
          "cores": 8,
          "shares": {
            "allocated": 40,
            "total": 52
          },
          "share_ratio": 82
        }
      }
    },
    "key1": {
      "count": 57.74,
      "locations": {
        "key0": 98,
        "key1": 97
      },
      "models": {
        "key0": 178,
        "key1": 179,
        "key2": 180
      },
      "resources": {
        "ram": {
          "total_mb": 88,
          "allocated_mb": 176,
          "used_mb": 246,
          "provisioned_mb": 52
        },
        "cpu": {
          "cores": 8,
          "shares": {
            "allocated": 40,
            "total": 52
          },
          "share_ratio": 82
        }
      }
    },
    "key2": {
      "count": 57.74,
      "locations": {
        "key0": 98,
        "key1": 97
      },
      "models": {
        "key0": 178,
        "key1": 179,
        "key2": 180
      },
      "resources": {
        "ram": {
          "total_mb": 88,
          "allocated_mb": 176,
          "used_mb": 246,
          "provisioned_mb": 52
        },
        "cpu": {
          "cores": 8,
          "shares": {
            "allocated": 40,
            "total": 52
          },
          "share_ratio": 82
        }
      }
    }
  },
  "server_ids": [
    "server_ids5"
  ]
}
```

