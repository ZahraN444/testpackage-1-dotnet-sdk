
# Job

A job resource.

## Structure

`Job`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Queue` | `string` | Required | A dash separated string showing the environment_id where the job is taking place. |
| `Caption` | `string` | Required | A short description of the job. |
| `Events` | [`JobEvents`](../../doc/models/job-events.md) | Required | A collection of timestamps for each event in the job's lifetime. |
| `Schedule` | `DateTime` | Required | A timestamp of when the job was scheduled. |
| `Tasks` | [`List<JobTask>`](../../doc/models/job-task.md) | Required | An array of job tasks. |
| `Expires` | `DateTime` | Required | A timestamp for when the job expires. |
| `Hash` | `string` | Required | A combination of the individual task details and job details. |
| `LimitDuplicates` | `bool` | Required | A boolean where true represents the job is set to prevent duplicates of itself quickly after creation. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `State` | [`JobState`](../../doc/models/job-state.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "queue": "queue0",
  "caption": "caption0",
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
  "hash": "hash2",
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
```

