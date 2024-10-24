
# IP Net

## Structure

`IPNet`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ip` | `string` | Required | The IP address. |
| `Cidr` | `string` | Required | The CIDR notation, describing the range of IP addresses. |

## Example (as JSON)

```json
{
  "ip": "fd00::21:0:0:0",
  "cidr": "fd00::21:0:0:0/96"
}
```

