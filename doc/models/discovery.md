
# Discovery

## Structure

`Discovery`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool?` | Optional | Whether or not the discovery service is enabled. |
| `ContainerId` | `string` | Optional | The ID of the discovery service container |
| `HighAvailability` | `bool?` | Optional | A boolean representing if this service container is set to high availability mode or not. |
| `AutoUpdate` | `bool?` | Optional | A boolean where `true` represents the desire to automatically update the environment discovery service. |
| `Config` | [`DiscoveryConfig2`](../../doc/models/containers/discovery-config-2.md) | Optional | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "enable": false,
  "container_id": "container_id4",
  "high_availability": false,
  "auto_update": false,
  "config": {
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
}
```

