
# Sleep Step

Settings for the sleep step for a pipeline.

## Structure

`SleepStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"sleep"` |
| `Details` | [`Details56`](../../doc/models/details-56.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "sleep",
  "details": {
    "duration": "72h45m2s"
  },
  "identifier": "identifier4",
  "options": {
    "skip": false
  }
}
```

