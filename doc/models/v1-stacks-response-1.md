
# V1 Stacks Response 1

## Structure

`V1StacksResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Stack`](../../doc/models/stack.md) | Required | Stacks are a way to orchestrate multiple containers atomically and automatically. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "identifier": "identifier8",
    "name": "name0",
    "hub_id": "651586fca6078e98982dbd90",
    "creator": {
      "type": "employee",
      "id": "651586fca6078e98982dbd90"
    },
    "source": {
      "type": "git-repo",
      "details": {
        "url": "url4",
        "branch": "branch6",
        "auth": {
          "type": "type0",
          "credentials": {
            "username": "username4",
            "password": "password0"
          }
        },
        "ref": {
          "type": "type0",
          "value": "value2"
        }
      }
    },
    "state": {
      "current": "deleted",
      "changed": "01/30/2021 08:30:00",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "events": {
      "created": "01/30/2021 08:30:00",
      "updated": "01/30/2021 08:30:00",
      "deleted": "01/30/2021 08:30:00",
      "last_build": "01/30/2021 08:30:00"
    },
    "variables": {
      "key0": "variables7",
      "key1": "variables8"
    },
    "meta": {
      "containers_count": {
        "state": {
          "key0": 148,
          "key1": 149,
          "key2": 150
        },
        "total": 80,
        "available": 126
      },
      "builds_count": {
        "state": {
          "key0": 112,
          "key1": 113
        },
        "total": 116,
        "available": 162
      }
    }
  }
}
```

