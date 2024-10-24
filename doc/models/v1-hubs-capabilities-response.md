
# V1 Hubs Capabilities Response

## Structure

`V1HubsCapabilitiesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<CapabilityEnum>`](../../doc/models/capability-enum.md) | Required | - |
| `Meta` | [`Meta15`](../../doc/models/meta-15.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
    "billing-services-manage",
    "billing-services-view"
  ],
  "meta": {
    "captions": {
      "key0": "captions5"
    }
  }
}
```

