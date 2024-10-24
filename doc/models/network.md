
# Network

SDN Network resource.

## Structure

`Network`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Name` | `string` | Required | The name of the network. |
| `Identifier` | `string` | Required | A network identifier used to construct http calls that specifically use this network over another. |
| `Cluster` | `string` | Required | The infrastructure cluster the environments belonging to this network belong to. |
| `Creator` | [`CreatorScope`](../../doc/models/creator-scope.md) | Required | The creator scope is embedded in resource objects to describe who created them |
| `HubId` | `string` | Required | The unique ID of the Hub this resource was created in. |
| `State` | [`NetworkState`](../../doc/models/network-state.md) | Required | - |
| `PrivateNetwork` | [`NetworkPrivateNetwork`](../../doc/models/containers/network-private-network.md) | Optional | This is a container for any-of cases. |
| `Environments` | [`List<Environment3>`](../../doc/models/environment-3.md) | Optional | An array of environments and timestamps. |
| `Events` | [`NetworkEvents`](../../doc/models/network-events.md) | Required | A collection of timestamps for each event in the network's lifetime. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "name": "name6",
  "identifier": "identifier6",
  "cluster": "cluster8",
  "creator": {
    "id": "651586fca6078e98982dbd90",
    "type": "employee"
  },
  "hub_id": "651586fca6078e98982dbd90",
  "state": {
    "current": "deleted",
    "changed": "01/30/2021 08:30:00",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "events": {
    "created": "01/30/2021 08:30:00",
    "updated": "01/30/2021 08:30:00",
    "deleted": "01/30/2021 08:30:00"
  },
  "private_network": {
    "vxlan_tag": 116,
    "subnet": "subnet6",
    "mac_addr_suffix": 120,
    "ipv6": {
      "ip": "ip0",
      "cidr": "cidr6"
    }
  },
  "environments": [
    {
      "id": "id2",
      "added": "2016-03-13T12:52:32.123Z"
    },
    {
      "id": "id2",
      "added": "2016-03-13T12:52:32.123Z"
    }
  ]
}
```

