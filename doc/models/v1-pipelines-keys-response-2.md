
# V1 Pipelines Keys Response 2

## Structure

`V1PipelinesKeysResponse2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`TriggerKey`](../../doc/models/trigger-key.md) | Optional | A pipeline trigger key resource. |

## Example (as JSON)

```json
{
  "data": {
    "id": "id0",
    "name": "name0",
    "secret": "secret6",
    "creator": {
      "id": "id8",
      "type": "employee"
    },
    "hub_id": "hub_id2",
    "pipeline_id": "pipeline_id4",
    "state": {
      "current": "deleted",
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
    },
    "ips": [
      "ips4",
      "ips5",
      "ips6"
    ]
  }
}
```

