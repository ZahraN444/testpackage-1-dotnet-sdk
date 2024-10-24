
# Container Image Summary

The Id of the image and information on if it is a service.

## Structure

`ContainerImageSummary`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `string` | Required | A 24 character hex string used to identify a unique resource. |
| `Service` | [`ServiceEnum?`](../../doc/models/service-enum.md) | Required | If this image is a service container this will say either `discovery` \| `loadbalancer` \| `vpn`. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "service": "discovery"
}
```

