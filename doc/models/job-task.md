
# Job Task

Information about a job task.

## Structure

`JobTask`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Caption` | `string` | Required | A short description of the task. |
| `Header` | `string` | Required | The API function called. |
| `Events` | [`TaskEvents`](../../doc/models/task-events.md) | Required | A collection of timestamps for each event in the job's lifetime. |
| `Steps` | [`List<TaskStep>`](../../doc/models/task-step.md) | Required | An array of job task steps. |
| `State` | [`TaskState`](../../doc/models/task-state.md) | Required | - |
| `Input` | `object` | Required | Input information used for the job tasks. |
| `Output` | `Dictionary<string, string>` | Required | Output informaiton used for the job tasks. |
| `Error` | [`Error5`](../../doc/models/error-5.md) | Required | An error object describing issues with the job. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "caption": "caption2",
  "header": "header8",
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
```

