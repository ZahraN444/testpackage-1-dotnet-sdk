
# Trigger Key

A pipeline trigger key resource.

## Structure

`TriggerKey`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Name` | `string` | Required | The name of the trigger key. |
| `Secret` | `string` | Required | The secret used when calling the trigger key programmatically. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `PipelineId` | `string` | Required | The ID for the pipeline related to this trigger key. |
| `State` | [`TriggerKeyState`](../../doc/models/trigger-key-state.md) | Required | - |
| `Events` | [`TriggerKeyEvents`](../../doc/models/trigger-key-events.md) | Required | A collection of timestamps for each event in the trigger key's lifetime. |
| `Ips` | `List<string>` | Required | An array of ips this trigger key is usable from. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "name": "name2",
  "secret": "secret8",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "hub_id": "651586fca6078e98982dbd90",
  "pipeline_id": "pipeline_id6",
  "state": {
    "current": "deleted",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00"
  },
  "ips": [
    "ips6",
    "ips7"
  ]
}
```

