
# Support Plan Features

Information about billing support plan features.

## Structure

`SupportPlanFeatures`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EngineeringSupport` | `bool` | Required | A boolean where true indicates the contract includes support for engineering. |
| `UptimeSla` | `bool` | Required | A boolean where true represents the contract has an uptime SLA agreement. |
| `GuaranteedResponseTime` | `string` | Required | The time in which this support contract guarantees response time. |

## Example (as JSON)

```json
{
  "engineering_support": false,
  "uptime_sla": false,
  "guaranteed_response_time": "guaranteed_response_time2"
}
```

