
# Legacy

## Structure

`Legacy`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Subnet` | `int?` | Optional | The IPv4 subnet Id. |
| `Ipv4` | [`LegacyIpv4`](../../doc/models/containers/legacy-ipv-4.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "subnet": 134,
  "ipv4": {
    "ip": "ip8",
    "cidr": "cidr4"
  }
}
```

