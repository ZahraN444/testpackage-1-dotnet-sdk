
# Interfaces

Network interface.

## Structure

`Interfaces`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Interface` | `string` | Optional | The interface name. |
| `Flags` | `string` | Optional | Flags for the given interface. |
| `Mtu` | `int?` | Optional | The maximum transmission unit for the interface. |
| `MacAddr` | `string` | Optional | The mac address for the interface. |
| `Addrs` | `List<string>` | Optional | An array of IP addresses associated with the interface. |

## Example (as JSON)

```json
{
  "interface": "interface2",
  "flags": "flags0",
  "mtu": 182,
  "mac_addr": "mac_addr2",
  "addrs": [
    "addrs3"
  ]
}
```

