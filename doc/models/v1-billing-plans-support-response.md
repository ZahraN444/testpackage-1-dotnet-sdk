
# V1 Billing Plans Support Response

## Structure

`V1BillingPlansSupportResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`List<SupportPlan>`](../../doc/models/support-plan.md) | Required | - |

## Example (as JSON)

```json
{
  "data": [
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
  ]
}
```

