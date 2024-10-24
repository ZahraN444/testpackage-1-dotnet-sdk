
# Config 5

## Structure

`Config5`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Runtime` | [`Config5Runtime`](../../doc/models/containers/config-5-runtime.md) | Optional | This is a container for any-of cases. |
| `Resources` | [`Config5Resources`](../../doc/models/containers/config-5-resources.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "runtime": {
    "workdir": "workdir0",
    "command": {
      "path": "path0",
      "args": "args6"
    },
    "environment_vars": {
      "key0": "environment_vars8",
      "key1": "environment_vars7"
    },
    "namespaces": [
      "mount",
      "user"
    ],
    "sysctl": {
      "key0": "sysctl8"
    }
  },
  "resources": {
    "cpu": {
      "shares": {
        "limit": 214,
        "reserve": 14
      },
      "cpus": "cpus2"
    },
    "ram": {
      "limit": "limit4",
      "reserve": "reserve0",
      "swappiness": 93.52
    }
  }
}
```

