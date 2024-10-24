
# Instances

Describes how many instances should be running

## Structure

`Instances`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Delta` | `int` | Required | Number of additional instances the auto-scaler will add/subtract per scaling event |
| `Max` | `int` | Required | Maximum additional instances the auto-scaler will run at any time |
| `MaxServer` | `int` | Required | Minimum number of instances per server |
| `MinTtl` | `string` | Required | Minimum amount of time an instance will live |

## Example (as JSON)

```json
{
  "delta": 254,
  "max": 150,
  "max_server": 154,
  "min_ttl": "72h45m2s"
}
```

