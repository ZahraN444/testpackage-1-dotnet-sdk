
# Security Incident

Details about a security incident/event that occurred.

## Structure

`SecurityIncident`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Risk` | [`Risk1Enum`](../../doc/models/risk-1-enum.md) | Required | The risk level of the security. |
| `Surface` | [`Surface1Enum`](../../doc/models/surface-1-enum.md) | Required | The vector of attack. |
| `Event` | [`Event3Enum`](../../doc/models/event-3-enum.md) | Required | How the platform handled the event. |
| `Attack` | [`Attack1Enum`](../../doc/models/attack-1-enum.md) | Required | The type of attack detected. |
| `Count` | `int` | Required | - |

## Example (as JSON)

```json
{
  "risk": "low",
  "surface": "fs",
  "event": "suggestion",
  "attack": "service-interruption",
  "count": 208
}
```

