
# Stack Container Scale Threshold Network Requests

Describes the network requests threshold at which scaling will occur

## Structure

`StackContainerScaleThresholdNetworkRequests`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Type` | `string` | Required, Constant | **Default**: `"network-requests"` |
| `Details` | [`Details18`](../../doc/models/details-18.md) | Required | - |

## Example (as JSON)

```json
{
  "type": "network-requests",
  "details": {
    "requests_total": 202
  }
}
```

