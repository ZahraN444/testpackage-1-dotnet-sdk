
# Cpu 1

Configurations settings related to CPU usage.

## Structure

`Cpu1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Shares` | [`Shares1`](../../doc/models/shares-1.md) | Optional | A share represents 1/10th of the available compute time on a single thread. |
| `Cpus` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "shares": {
    "limit": 214,
    "reserve": 14
  },
  "cpus": "cpus2"
}
```

