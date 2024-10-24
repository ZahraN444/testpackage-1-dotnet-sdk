
# Usage

Usage statistics.

## Structure

`Usage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Total` | `int` | Required | Total amount of VPU time since last restart. |
| `PerCore` | `List<int>` | Required | An array showing CPU core specific usage in nanoseconds since the last restart. |
| `Kernel` | `int` | Required | The amount of time in nanoseconds used by the kernel since last restart. |
| `User` | `double` | Required | The amount of time in nanoseconds taken up for user processes. |

## Example (as JSON)

```json
{
  "total": 126,
  "per_core": [
    251
  ],
  "kernel": 44,
  "user": 193.04
}
```

