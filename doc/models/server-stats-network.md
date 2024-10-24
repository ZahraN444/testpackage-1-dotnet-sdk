
# Server Stats Network

Statistics about the networks on a given server.

## Structure

`ServerStatsNetwork`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Interfaces` | [`Dictionary<string, Interfaces>`](../../doc/models/interfaces.md) | Optional | Network interfaces for a given server. |
| `ExternalIpv4` | `string` | Required | The public IPv4 address used to connect to this server. |
| `ExternalIpv6` | `string` | Required | The public IPv6 address used to connect to this server. |

## Example (as JSON)

```json
{
  "interfaces": {
    "key0": {
      "interface": "interface8",
      "flags": "flags6",
      "mtu": 38,
      "mac_addr": "mac_addr8",
      "addrs": [
        "addrs9",
        "addrs0"
      ]
    },
    "key1": {
      "interface": "interface8",
      "flags": "flags6",
      "mtu": 38,
      "mac_addr": "mac_addr8",
      "addrs": [
        "addrs9",
        "addrs0"
      ]
    },
    "key2": {
      "interface": "interface8",
      "flags": "flags6",
      "mtu": 38,
      "mac_addr": "mac_addr8",
      "addrs": [
        "addrs9",
        "addrs0"
      ]
    }
  },
  "external_ipv4": "external_ipv42",
  "external_ipv6": "external_ipv68"
}
```

