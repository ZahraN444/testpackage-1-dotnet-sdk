
# Activity Security

Security information pertaining to this activity.

## Structure

`ActivitySecurity`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Risk` | [`RiskEnum`](../../doc/models/risk-enum.md) | Required | A risk level assessed by the platform. Depending on the nature of the incident, this may change even if the event type is the same. |
| `Surface` | [`SurfaceEnum`](../../doc/models/surface-enum.md) | Required | From where the platform has determined this security event originated from. |
| `Event` | [`EventEnum`](../../doc/models/event-enum.md) | Required | How the platform has handled this security event. |
| `Attack` | [`AttackEnum`](../../doc/models/attack-enum.md) | Required | The type of attack the platform has determined has occurred. |

## Example (as JSON)

```json
{
  "risk": "low",
  "surface": "network",
  "event": "suggestion",
  "attack": "access-elevation"
}
```

