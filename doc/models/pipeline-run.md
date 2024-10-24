
# Pipeline Run

A pipeline run resource.

## Structure

`PipelineRun`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `PipelineId` | `string` | Required | The ID for the pipeline this run belongs to. |
| `Stages` | [`List<Stage>`](../../doc/models/stage.md) | Required | An array of pipeline stages. |
| `State` | [`PipelineRunState`](../../doc/models/pipeline-run-state.md) | Required | - |
| `Events` | [`PipelineRunEvents`](../../doc/models/pipeline-run-events.md) | Required | A collection of timestamps for each event in the pipeline run's lifetime. |
| `Variables` | `Dictionary<string, string>` | Optional | A map of variable values used during pipeline run. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "hub_id": "651586fca6078e98982dbd90",
  "pipeline_id": "pipeline_id8",
  "stages": [
    {
      "identifier": "identifier2",
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
  ],
  "state": {
    "current": "running",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "events": {
    "started": "01/30/2021 08:30:00",
    "queued": "01/30/2021 08:30:00",
    "finished": "01/30/2021 08:30:00"
  },
  "variables": {
    "key0": "variables3",
    "key1": "variables2"
  }
}
```

