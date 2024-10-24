
# Infrastructure IP Pool

An IP Pool

## Structure

`InfrastructureIPPool`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `ServerId` | `string` | Required | An ID associated with a server resource. |
| `LocationId` | `string` | Required | An ID associated with a location resource. |
| `Kind` | [`Kind1Enum`](../../doc/models/kind-1-enum.md) | Required | The type of IP pool. |
| `Provider` | [`IPPoolProvider`](../../doc/models/ip-pool-provider.md) | Required | A IP Pool provider. |
| `Floating` | `bool` | Required | A boolean where true represents the pool as a floating IP pool. |
| `Ips` | [`Ips`](../../doc/models/ips.md) | Required | Data about IPs in the pool. |
| `Block` | [`Block`](../../doc/models/block.md) | Required | Network information about the pool. |
| `State` | [`PoolState`](../../doc/models/pool-state.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "server_id": "server_id0",
  "location_id": "location_id4",
  "kind": "ipv4",
  "provider": {
    "vendor": "vendor4",
    "integration_id": "651586fca6078e98982dbd90",
    "location": "location2",
    "reservation": "reservation2",
    "server": "server2",
    "server_assignment": "server_assignment4"
  },
  "floating": false,
  "ips": {
    "total": 178,
    "available": 124
  },
  "block": {
    "cidr": "cidr2",
    "gateway": "gateway2",
    "netmask": "netmask2",
    "network": "network8"
  },
  "state": {
    "current": "released",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  }
}
```

