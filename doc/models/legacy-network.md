
# Legacy Network

Legacy network information for an Environment.

## Structure

`LegacyNetwork`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Subnet` | `int` | Required | The IPv4 subnet Id. |
| `Ipv4` | [`LegacyNetworkIpv4`](../../doc/models/containers/legacy-network-ipv-4.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "subnet": 58,
  "ipv4": {
    "ip": "ip8",
    "cidr": "cidr4"
  }
}
```

