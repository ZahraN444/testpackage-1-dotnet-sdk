
# Mounted FS

Mounted filesystem information.

## Structure

`MountedFS`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Device` | `string` | Optional | The device assocaited with the mount. |
| `Type` | `string` | Required | The type of filesystem in use by the mount. |
| `Mountpoint` | `string` | Optional | The path the mount is associated with. |
| `Total` | `int` | Required | The total amount of storage in KB available at this mount. |
| `Free` | `int` | Required | The amount of uninitialized storage in KB. |
| `Used` | `int` | Required | The amount of storage being used in KB. |

## Example (as JSON)

```json
{
  "device": "device2",
  "type": "type6",
  "mountpoint": "mountpoint6",
  "total": 236,
  "free": 74,
  "used": 42
}
```

