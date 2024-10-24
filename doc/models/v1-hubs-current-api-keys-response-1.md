
# V1 Hubs Current Api Keys Response 1

## Structure

`V1HubsCurrentApiKeysResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`ApiKey`](../../doc/models/api-key.md) | Optional | An API key resource |

## Example (as JSON)

```json
{
  "data": {
    "id": "id0",
    "hub_id": "hub_id2",
    "name": "name0",
    "creator": {
      "id": "id8",
      "type": "employee"
    },
    "secret": "secret6",
    "permissions": {
      "all_environments": false,
      "environments": [
        {
          "id": "id2",
          "manage": false
        }
      ]
    },
    "capabilities": {
      "all": false,
      "specific": [
        "pipelines-view"
      ]
    },
    "ips": [
      "ips4",
      "ips5",
      "ips6"
    ],
    "state": {
      "current": "live",
      "changed": "2016-03-13T12:52:32.123Z",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "events": {
      "created": "2016-03-13T12:52:32.123Z",
      "updated": "2016-03-13T12:52:32.123Z",
      "deleted": "2016-03-13T12:52:32.123Z"
    }
  }
}
```

