
# IP

Details about an IP.

## Structure

`IP`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `Kind` | [`KindEnum`](../../doc/models/kind-enum.md) | Required | The type of IP protocol this IP is. |
| `Assignment` | [`Assignment`](../../doc/models/assignment.md) | Optional | Information about the assignment of this IP. |
| `PoolId` | `string` | Required | A unique identifier that associates the IP with an IP pool. |
| `Address` | `string` | Required | The IP address. |
| `Gateway` | `string` | Required | The IP gateway. |
| `Cidr` | `string` | Required | The CIDR for the IP. |
| `State` | [`IpState`](../../doc/models/ip-state.md) | Required | - |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "hub_id": "651586fca6078e98982dbd90",
  "kind": "ipv4",
  "pool_id": "pool_id8",
  "address": "address2",
  "gateway": "gateway6",
  "cidr": "cidr6",
  "state": {
    "current": "releasing",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "assignment": {
    "container_id": "container_id2",
    "instance_id": "instance_id4",
    "environment_id": "environment_id4"
  }
}
```

