
# Container Environment Summary

A summary of supplemental environment and network information specific to a container.

## Structure

`ContainerEnvironmentSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Cluster` | `string` | Required | The cluster this environment is associated with. |
| `ContainerSubnet` | `string` | Optional | The private network subnet ID for this container and its instances. |
| `Ipv6` | [`ContainerEnvironmentSummaryIpv6`](../../doc/models/containers/container-environment-summary-ipv-6.md) | Optional | This is a container for any-of cases. |
| `Legacy` | [`ContainerEnvironmentSummaryLegacy`](../../doc/models/containers/container-environment-summary-legacy.md) | Required | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "cluster": "cluster8",
  "legacy": {
    "subnet": 58,
    "ipv4": {
      "ip": "ip8",
      "cidr": "cidr4"
    }
  },
  "container_subnet": "container_subnet4",
  "ipv6": {
    "ip": "ip8",
    "cidr": "cidr4"
  }
}
```

