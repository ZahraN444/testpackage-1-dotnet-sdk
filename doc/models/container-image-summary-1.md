
# Container Image Summary 1

A summary of the image this container was created from.

## Structure

`ContainerImageSummary1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | [`ContainerImageSummary1Id`](../../doc/models/containers/container-image-summary-1-id.md) | Required | This is a container for any-of cases. |
| `Extension` | [`Extension`](../../doc/models/extension.md) | Required | An image that is packaged with Cycle directly, such as the global load balancer. |
| `Service` | [`ContainerImageSummary1Service`](../../doc/models/containers/container-image-summary-1-service.md) | Required | This is a container for any-of cases. |

## Example (as JSON)

```json
{
  "id": "651586fca6078e98982dbd90",
  "extension": {
    "identifier": "identifier6"
  },
  "service": "vpn"
}
```

