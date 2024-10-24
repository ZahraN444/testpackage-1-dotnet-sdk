
# Job State

## Structure

`JobState`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Current` | [`Current34Enum`](../../doc/models/current-34-enum.md) | Required | The current state of the job. |
| `Changed` | `DateTime?` | Optional | - |
| `Error` | [`Error6`](../../doc/models/error-6.md) | Required | An error, if any, that has occurred for this job. |

## Example (as JSON)

```json
{
  "current": "running",
  "changed": "01/30/2021 08:30:00",
  "error": {
    "message": "message4"
  }
}
```

