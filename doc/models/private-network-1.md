
# Private Network 1

## Structure

`PrivateNetwork1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VxlanTag` | `int?` | Optional | The vxlan tag added to each packet to help identify the network. |
| `Subnet` | `string` | Optional | The subnet ID. |
| `Ipv6` | [`IPNet`](../../doc/models/ip-net.md) | Optional | - |
| `Legacy` | [`PrivateNetwork1Legacy`](../../doc/models/containers/private-network-1-legacy.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "vxlan_tag": 192,
  "subnet": "subnet2",
  "ipv6": {
    "ip": "ip0",
    "cidr": "cidr6"
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

