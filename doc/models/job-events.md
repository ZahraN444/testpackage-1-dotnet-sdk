
# Job Events

A collection of timestamps for each event in the job's lifetime.

## Structure

`JobEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Queued` | `DateTime` | Required | The timestamp of when the job was queued. |
| `Completed` | `DateTime` | Required | The timestamp of when the job was completed. |
| `Started` | `DateTime` | Required | The timestamp of when the job was started. |

## Example (as JSON)

```json
{
  "queued": "01/30/2021 08:30:00",
  "completed": "01/30/2021 08:30:00",
  "started": "01/30/2021 08:30:00"
}
```

