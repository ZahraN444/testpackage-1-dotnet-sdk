
# Billing Image Storage

An object holding information about servers included in Billing tier

## Structure

`BillingImageStorage`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IncludedGb` | `double` | Required | The GB of image storage included in tier |
| `AdditionalGb` | [`AdditionalGb`](../../doc/models/additional-gb.md) | Required | Additional cost for image storage exceeding included_gb |
| `HardCap` | `bool` | Required | A boolean indicating if there is a hard limit on the image storage |

## Example (as JSON)

```json
{
  "included_gb": 185.68,
  "additional_gb": {
    "mills": 25.1,
    "term": "monthly"
  },
  "hard_cap": false
}
```

