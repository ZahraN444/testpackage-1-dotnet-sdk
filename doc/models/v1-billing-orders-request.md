
# V1 Billing Orders Request

## Structure

`V1BillingOrdersRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TierPlanId` | `string` | Optional | ID associated with the tier plan |
| `SupportPlanId` | `string` | Optional | ID associated with the support plan |
| `TermLength` | [`TermLengthEnum?`](../../doc/models/term-length-enum.md) | Optional | String that defines term length |
| `PromoCode` | `string` | Optional | String that defines a promo code |

## Example (as JSON)

```json
{
  "tier_plan_id": "tier_plan_id6",
  "support_plan_id": "support_plan_id0",
  "term_length": "monthly",
  "promo_code": "promo_code4"
}
```

