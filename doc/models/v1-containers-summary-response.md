
# V1 Containers Summary Response

## Structure

`V1ContainersSummaryResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`Data3`](../../doc/models/data-3.md) | Required | Contains useful and relevant data/statistics for a container that would otherwise be several separate API calls. |

## Example (as JSON)

```json
{
  "data": {
    "id": "651586fca6078e98982dbd90",
    "state": {
      "current": "deleting",
      "changed": "01/30/2021 08:30:00",
      "desired": "stopping",
      "error": {
        "message": "message4",
        "time": "2016-03-13T12:52:32.123Z"
      }
    },
    "stats": {
      "state": {
        "key0": 140
      },
      "total": 28,
      "available": 74
    }
  }
}
```

