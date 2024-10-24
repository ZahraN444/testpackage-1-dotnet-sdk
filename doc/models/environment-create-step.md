
# Environment Create Step

Settings for creating an environment in a pipeline.

## Structure

`EnvironmentCreateStep`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Identifier` | `string` | Optional | An identifier for the step. |
| `Options` | [`Options3`](../../doc/models/options-3.md) | Optional | - |
| `Action` | `string` | Required, Constant | The action that the step takes.<br>**Default**: `"environment.create"` |
| `Details` | [`Details43`](../../doc/models/details-43.md) | Required | - |

## Example (as JSON)

```json
{
  "action": "environment.create",
  "details": {
    "name": "name0",
    "about": {
      "description": "description4",
      "favorite": false
    },
    "cluster": "cluster6",
    "features": {
      "legacy_networking": false
    }
  },
  "identifier": "identifier4",
  "options": {
    "skip": false
  }
}
```

