
# Hosts

## Structure

`Hosts`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Ipv4` | `List<string>` | Optional | The IPv4 address the discovery server should return to any container instance requesting this hostname. |
| `Ipv6` | `List<string>` | Optional | The IPv6 address the discovery server should return to any container instance requesting this hostname. |

## Example (as JSON)

```json
{
  "ipv4": [
    "ipv44",
    "ipv45"
  ],
  "ipv6": [
    "ipv64",
    "ipv65",
    "ipv66"
  ]
}
```

