
# Stage

## Structure

`Stage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Required | A stage identifier. |
| `Steps` | [`List<Step>`](../../doc/models/step.md) | Required | - |
| `Events` | [`PipelineRunEvents`](../../doc/models/pipeline-run-events.md) | Required | A collection of timestamps for each event in the pipeline run's lifetime. |

## Example (as JSON)

```json
{
  "identifier": "identifier6",
  "steps": [
    {
      "identifier": "identifier0",
      "action": "environment.create",
      "events": {
        "started": "01/30/2021 08:30:00",
        "queued": "01/30/2021 08:30:00",
        "finished": "01/30/2021 08:30:00"
      },
      "success": false,
      "error": {
        "message": "message4"
      }
    }
  ],
  "events": {
    "started": "01/30/2021 08:30:00",
    "queued": "01/30/2021 08:30:00",
    "finished": "01/30/2021 08:30:00"
  }
}
```

