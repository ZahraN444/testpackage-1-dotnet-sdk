
# Job 2

Contains some basic information about the job associated with this task.

## Structure

`Job2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | The ID of the job |
| `Accepted` | `bool` | Required | Describes if the job has been accepted |
| `Queue` | `string` | Required | Describes the queue this job is a part of. |
| `Schedule` | `DateTime` | Required | - |
| `Parallel` | [`Parallel`](../../doc/models/parallel.md) | Required | - |
| `Tasks` | [`List<NewTask>`](../../doc/models/new-task.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "id6",
  "accepted": false,
  "queue": "queue0",
  "schedule": "01/30/2021 08:30:00",
  "parallel": {
    "sub_queue": "sub_queue0",
    "tasks": false
  },
  "tasks": [
    {
      "caption": "caption4",
      "header": "header6",
      "steps": [
        {
          "caption": "caption6",
          "description": "description2",
          "started": "01/30/2021 08:30:00",
          "completed": "01/30/2021 08:30:00"
        }
      ],
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
      }
    }
  ]
}
```

