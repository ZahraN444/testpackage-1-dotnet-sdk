
# Environment Network Summary

Details about the environment network this instance is a member of.

## Structure

`EnvironmentNetworkSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `NetworkSubnet` | `string` | Required | - |
| `Subnet` | `string` | Required | - |
| `Ipv6` | [`EnvironmentNetworkSummaryIpv6`](../../doc/models/containers/environment-network-summary-ipv-6.md) | Required | This is a container for any-of cases. |
| `Legacy` | [`Legacy2`](../../doc/models/legacy-2.md) | Required | - |
| `MacAddr` | `string` | Required | - |
| `VxlanTag` | `int` | Required | - |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "network_subnet": "network_subnet6",
  "subnet": "subnet8",
  "ipv6": {
    "ip": "fd00::21:0:0:0",
    "cidr": "fd00::21:0:0:0/96"
  },
  "legacy": {
    "host": 138,
    "subnet": 90,
    "ipv4": {
      "ip": "fd00::21:0:0:0",
      "cidr": "fd00::21:0:0:0/96"
    }
  },
  "mac_addr": "mac_addr4",
  "vxlan_tag": 74
}
```

