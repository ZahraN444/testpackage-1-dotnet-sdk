
# Pipeline Events

A collection of timestamps for each event in the pipeline's lifetime.

## Structure

`PipelineEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Created` | `DateTime` | Required | The timestamp of when the pipeline was created. |
| `Updated` | `DateTime` | Required | The timestamp of when the pipeline was updated. |
| `Deleted` | `DateTime` | Required | The timestamp of when the pipeline was deleted. |
| `LastRun` | `DateTime` | Required | The timestamp of when the pipeline was last run. |

## Example (as JSON)

```json
{
  "created": "01/30/2021 08:30:00",
  "updated": "01/30/2021 08:30:00",
  "deleted": "01/30/2021 08:30:00",
  "last_run": "01/30/2021 08:30:00"
}
```

