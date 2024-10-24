
# Legacy 2

## Structure

`Legacy2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Host` | `int` | Required | - |
| `Subnet` | `int` | Required | - |
| `Ipv4` | [`Legacy2Ipv4`](../../doc/models/containers/legacy-2-ipv-4.md) | Required | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "host": 150,
  "subnet": 102,
  "ipv4": {
    "ip": "fd00::21:0:0:0",
    "cidr": "fd00::21:0:0:0/96"
  }
}
```

