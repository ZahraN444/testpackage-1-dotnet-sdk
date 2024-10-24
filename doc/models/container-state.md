
# Container State

## Structure

`ContainerState`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Current` | [`Current11Enum`](../../doc/models/current-11-enum.md) | Required | The current state of the container. |
| `Desired` | [`DesiredEnum?`](../../doc/models/desired-enum.md) | Optional | The desired state of the container. |
| `Changed` | `DateTime` | Required | - |
| `Error` | [`Error1`](../../doc/models/error-1.md) | Optional | An error, if any, that has occurred for this resource. |

## Example (as JSON)

```json
{
  "current": "stopping",
  "changed": "01/30/2021 08:30:00",
  "desired": "deleting",
  "error": {
    "message": "message4",
    "time": "2016-03-13T12:52:32.123Z"
  }
}
```

