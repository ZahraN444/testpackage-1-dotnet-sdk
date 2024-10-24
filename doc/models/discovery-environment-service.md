
# Discovery Environment Service

Information about the environments discovery service(s).

## Structure

`DiscoveryEnvironmentService`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Enable` | `bool` | Required | Whether or not the discovery service is enabled. |
| `ContainerId` | `string` | Required | The ID of the discovery service container |
| `HighAvailability` | `bool` | Required | A boolean representing if this service container is set to high availability mode or not. |
| `AutoUpdate` | `bool?` | Optional | A boolean where `true` represents the desire to automatically update the environment discovery service. |
| `Config` | [`DiscoveryEnvironmentServiceConfig`](../../doc/models/containers/discovery-environment-service-config.md) | Required | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "enable": false,
  "container_id": "container_id6",
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

