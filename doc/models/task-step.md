
# Task Step

A step for a given job task.

## Structure

`TaskStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Caption` | `string` | Required | A short description of the step. |
| `Description` | `string` | Required | A more verbose description. |
| `Started` | `DateTime` | Required | A timestamp for when the step started. |
| `Completed` | `DateTime` | Required | A timestamp for when the step completed. |

## Example (as JSON)

```json
{
  "caption": "caption8",
  "description": "description4",
  "started": "01/30/2021 08:30:00",
  "completed": "01/30/2021 08:30:00"
}
```

