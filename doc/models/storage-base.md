
# Storage Base

Telemetry data for the base volume of a given server.

## Structure

`StorageBase`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Used` | `int` | Required | The amount of storage currently used in the base volume. |
| `Free` | `int` | Required | The amount of free space on the base volume. |
| `Total` | `int` | Required | The total amount of space on the base volume. |

## Example (as JSON)

```json
{
  "used": 24,
  "free": 56,
  "total": 38
}
```

