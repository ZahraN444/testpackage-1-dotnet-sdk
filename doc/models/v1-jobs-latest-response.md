
# V1 Jobs Latest Response

## Structure

`V1JobsLatestResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<Job>`](../../doc/models/job.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    {
      "id": "651586fca6078e98982dbd90",
      "hub_id": "651586fca6078e98982dbd90",
      "queue": "queue4",
      "caption": "caption4",
      "events": {
        "queued": "01/30/2021 08:30:00",
        "completed": "01/30/2021 08:30:00",
        "started": "01/30/2021 08:30:00"
      },
      "schedule": "01/30/2021 08:30:00",
      "tasks": [
        {
          "id": "651586fca6078e98982dbd90",
          "caption": "caption4",
          "header": "header6",
          "events": {
            "queued": "01/30/2021 08:30:00",
            "completed": "01/30/2021 08:30:00",
            "started": "01/30/2021 08:30:00"
          },
          "steps": [
            {
              "caption": "caption6",
              "description": "description2",
              "started": "01/30/2021 08:30:00",
              "completed": "01/30/2021 08:30:00"
            }
          ],
          "state": {
            "changed": "01/30/2021 08:30:00",
            "current": "running"
          },
          "input": {
            "key0": {
              "key1": "val1",
              "key2": "val2"
            },
            "key1": {
              "key1": "val1",
              "key2": "val2"
            },
            "key2": {
              "key1": "val1",
              "key2": "val2"
            }
          },
          "output": {
            "key0": "output2"
          },
          "error": {
            "message": "message4"
          }
        }
      ],
      "expires": "01/30/2021 08:30:00",
      "hash": "hash6",
      "limit_duplicates": false,
      "creator": {
        "id": "651586fca6078e98982dbd90",
        "type": "employee"
      },
      "state": {
        "current": "error",
        "changed": "01/30/2021 08:30:00",
        "error": {
          "message": "message4"
        }
      }
    }
  ]
}
```

