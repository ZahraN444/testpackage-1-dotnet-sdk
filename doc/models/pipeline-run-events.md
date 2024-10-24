
# Pipeline Run Events

A collection of timestamps for each event in the pipeline run's lifetime.

## Structure

`PipelineRunEvents`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Started` | `DateTime` | Required | The timestamp of when the pipeline run was started. |
| `Queued` | `DateTime` | Required | The timestamp of when the pipeline run was queued. |
| `Finished` | `DateTime` | Required | The timestamp of when the pipeline run was finished. |

## Example (as JSON)

```json
{
  "started": "01/30/2021 08:30:00",
  "queued": "01/30/2021 08:30:00",
  "finished": "01/30/2021 08:30:00"
}
```

