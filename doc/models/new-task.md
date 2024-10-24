
# New Task

## Structure

`NewTask`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Caption` | `string` | Required | A short description of the task. |
| `Header` | `string` | Required | The API function called. |
| `Steps` | [`List<TaskStep>`](../../doc/models/task-step.md) | Required | An array of job task steps. |
| `Input` | `object` | Required | Input information used for the job tasks. |

## Example (as JSON)

```json
{
  "caption": "caption0",
  "header": "header0",
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
    }
  }
}
```

