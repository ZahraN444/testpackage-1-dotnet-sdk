
# Private Network

## Structure

`PrivateNetwork`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VxlanTag` | `int` | Required | The vxlan tag added to each packet to help identify the network. |
| `Subnet` | `string` | Required | The subnet ID. |
| `Ipv6` | [`IPNet`](../../doc/models/ip-net.md) | Required | - |
| `Legacy` | [`PrivateNetworkLegacy`](../../doc/models/containers/private-network-legacy.md) | Required | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "vxlan_tag": 126,
  "subnet": "subnet8",
  "ipv6": {
    "ip": "fd00::21:0:0:0",
    "cidr": "fd00::21:0:0:0/96"
  },
  "legacy": {
    "subnet": 58,
    "ipv4": {
      "ip": "ip8",
      "cidr": "cidr4"
    }
  }
}
```

