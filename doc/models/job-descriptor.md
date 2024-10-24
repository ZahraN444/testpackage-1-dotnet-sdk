
# Job Descriptor

A Job Descriptor is returned on success by API calls that create jobs. It contains the action that was requested, as well as the ID of the job created as a result.

## Structure

`JobDescriptor`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Action` | `string` | Required | The action that was taken. |
| `Job` | [`Job2`](../../doc/models/job-2.md) | Optional | Contains some basic information about the job associated with this task. |

## Example (as JSON)

```json
{
  "action": "action8",
  "job": {
    "id": "id6",
    "accepted": false,
    "queue": "queue0",
    "schedule": "2016-03-13T12:52:32.123Z",
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
            "started": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
          },
          {
            "caption": "caption6",
            "description": "description2",
            "started": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
          },
          {
            "caption": "caption6",
            "description": "description2",
            "started": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
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
      },
      {
        "caption": "caption4",
        "header": "header6",
        "steps": [
          {
            "caption": "caption6",
            "description": "description2",
            "started": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
          },
          {
            "caption": "caption6",
            "description": "description2",
            "started": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
          },
          {
            "caption": "caption6",
            "description": "description2",
            "started": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
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
      },
      {
        "caption": "caption4",
        "header": "header6",
        "steps": [
          {
            "caption": "caption6",
            "description": "description2",
            "started": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
          },
          {
            "caption": "caption6",
            "description": "description2",
            "started": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
          },
          {
            "caption": "caption6",
            "description": "description2",
            "started": "2016-03-13T12:52:32.123Z",
            "completed": "2016-03-13T12:52:32.123Z"
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
}
```

