
# Container 2

## Structure

`Container2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Name` | `string` | Required | A user defined name for the container resource. |
| `State` | [`ContainerState`](../../doc/models/container-state.md) | Required | - |
| `Image` | [`ContainerImageSummary`](../../doc/models/container-image-summary.md) | Required | The Id of the image and information on if it is a service. |
| `Environment` | [`ContainerEnvironmentSummary`](../../doc/models/container-environment-summary.md) | Required | A summary of supplemental environment and network information specific to a container. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "name": "name8",
  "state": {
    "current": "deleting",
    "changed": "01/30/2021 08:30:00",
    "desired": "stopping",
    "error": {
      "message": "message4",
      "time": "2016-03-13T12:52:32.123Z"
    }
  },
  "image": {
    "id": "651586fca6078e98982dbd90",
    "service": "discovery"
  },
  "environment": {
    "id": "651586fca6078e98982dbd90",
    "cluster": "cluster8",
    "legacy": {
      "subnet": 58,
      "ipv4": {
        "ip": "ip8",
        "cidr": "cidr4"
      }
    },
    "container_subnet": "container_subnet6",
    "ipv6": {
      "ip": "ip8",
      "cidr": "cidr4"
    }
  }
}
```

