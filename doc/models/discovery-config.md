
# Discovery Config

The config object for the discovery service.

## Structure

`DiscoveryConfig`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Hosts` | [`Dictionary<string, Hosts>`](../../doc/models/hosts.md) | Optional | A mapping of hostnames to IP addresses for custom internal resolutions. Acts as a custom /etc/resolv.conf file that works environment wide. |

## Example (as JSON)

```json
{
  "hosts": {
    "key0": {
      "ipv4": [
        "ipv42",
        "ipv43"
      ],
      "ipv6": [
        "ipv66",
        "ipv67",
        "ipv68"
      ]
    }
  }
}
```

