
# Private Network 2

## Structure

`PrivateNetwork2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VxlanTag` | `int?` | Optional | A tag used to ensure proper routing. |
| `Subnet` | `string` | Optional | The subnet of the private network. |
| `MacAddrSuffix` | `int?` | Optional | A number used to ensure a MAC address exists for each network. |
| `Ipv6` | [`Ipv63`](../../doc/models/ipv-63.md) | Optional | IPv6 infromation for the network. |

## Example (as JSON)

```json
{
  "vxlan_tag": 218,
  "subnet": "subnet4",
  "mac_addr_suffix": 222,
  "ipv6": {
    "ip": "ip0",
    "cidr": "cidr6"
  }
}
```

