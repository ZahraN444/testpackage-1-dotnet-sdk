
# Server Stats OS

Statistics about the operating system installed on the server (CycleOS).

## Structure

`ServerStatsOS`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Release` | `string` | Optional | The currently installed release version of the OS. |
| `Kernel` | `string` | Optional | The currently installed kernel version. |
| `Hostname` | `string` | Optional | The hostname as set by the given server's OS. |

## Example (as JSON)

```json
{
  "release": "release2",
  "kernel": "kernel4",
  "hostname": "hostname4"
}
```

