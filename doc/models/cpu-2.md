
# Cpu 2

Information about CPU resources.

## Structure

`Cpu2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Cores` | `int` | Required | The number of CPU cores. |
| `Shares` | [`Shares2`](../../doc/models/shares-2.md) | Required | Information about CPU shares. |
| `ShareRatio` | `int?` | Optional | The ratio of shares allocated to total shares. |

## Example (as JSON)

```json
{
  "cores": 240,
  "shares": {
    "allocated": 40,
    "total": 52
  },
  "share_ratio": 106
}
```

