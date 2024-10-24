
# Stack Spec Test Container

## Structure

`StackSpecTestContainer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | - |
| `Image` | [`StackSpecTestContainerImage`](../../doc/models/containers/stack-spec-test-container-image.md) | Required | This is a container for any-of cases. |
| `Config` | [`Config5`](../../doc/models/config-5.md) | Required | - |

## Example (as JSON)

```json
{
  "name": "name8",
  "image": {
    "name": "name6",
    "origin": {
      "type": "docker-hub",
      "details": {
        "existing": {
          "source_id": "source_id8"
        },
        "target": "target8",
        "username": "username0",
        "token": "token4"
      }
    },
    "build": {
      "args": {
        "key0": "args9"
      }
    },
    "builder": {
      "integration_id": "integration_id6"
    }
  },
  "config": {
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
}
```

