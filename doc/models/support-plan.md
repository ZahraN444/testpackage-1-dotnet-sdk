
# Support Plan

Information about a billing support plan.

## Structure

`SupportPlan`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | The name of the support plan. |
| `Price` | [`BillingAmount`](../../doc/models/billing-amount.md) | Required | An object holding information about term and amount that relates to a specific billing component. |
| `Description` | `string` | Required | Information about the billing support plan that describes the plan. |
| `Features` | [`SupportPlanFeatures`](../../doc/models/support-plan-features.md) | Required | Information about billing support plan features. |
| `Contract` | `bool` | Required | A boolean where true represents the plan is a long term contract, not just month to month. |
| `Default` | `bool` | Required | This returns true if it shows up. |

## Example (as JSON)

```json
{
  "name": "name0",
  "price": {
    "mills": 210,
    "term": "monthly"
  },
  "description": "description0",
  "features": {
    "engineering_support": false,
    "uptime_sla": false,
    "guaranteed_response_time": "guaranteed_response_time0"
  },
  "contract": false,
  "default": false
}
```

