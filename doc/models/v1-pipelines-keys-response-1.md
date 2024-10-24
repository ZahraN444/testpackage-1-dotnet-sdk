
# V1 Pipelines Keys Response 1

## Structure

`V1PipelinesKeysResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`TriggerKey`](../../doc/models/trigger-key.md) | Required | A pipeline trigger key resource. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "name": "name0",
    "secret": "secret6",
    "creator": {
      "id": "651586fca6078e98982dbd90",
      "type": "employee"
    },
    "hub_id": "651586fca6078e98982dbd90",
    "pipeline_id": "pipeline_id4",
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
      "deleted": "01/30/2021 08:30:00"
    },
    "ips": [
      "ips4",
      "ips5",
      "ips6"
    ]
  }
}
```

