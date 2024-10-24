
# Step

## Structure

`Step`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Required | - |
| `Action` | [`Action1Enum`](../../doc/models/action-1-enum.md) | Required | - |
| `Events` | [`PipelineRunEvents`](../../doc/models/pipeline-run-events.md) | Required | A collection of timestamps for each event in the pipeline run's lifetime. |
| `Success` | `bool` | Required | - |
| `Error` | [`Error4`](../../doc/models/error-4.md) | Optional | An error, if any, that has occurred for this step. |

## Example (as JSON)

```json
{
  "identifier": "identifier2",
  "action": "image.source.create",
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
```

