
# Network Privacy Settings

Private network information for a Cycle SDN.

## Structure

`NetworkPrivacySettings`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `VxlanTag` | `int` | Required | A tag used to ensure proper routing. |
| `Subnet` | `string` | Required | The subnet of the private network. |
| `MacAddrSuffix` | `int` | Required | A number used to ensure a MAC address exists for each network. |
| `Ipv6` | [`Ipv63`](../../doc/models/ipv-63.md) | Required | IPv6 infromation for the network. |

## Example (as JSON)

```json
{
  "vxlan_tag": 116,
  "subnet": "subnet6",
  "mac_addr_suffix": 120,
  "ipv6": {
    "ip": "ip0",
    "cidr": "cidr6"
  }
}
```

