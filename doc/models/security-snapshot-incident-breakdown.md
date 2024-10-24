
# Security Snapshot Incident Breakdown

A breakdown of a snapshot's incidents inside a security report.

## Structure

`SecuritySnapshotIncidentBreakdown`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Surface` | [`Surface2`](../../doc/models/surface-2.md) | Required | - |
| `Attack` | [`Attack2`](../../doc/models/attack-2.md) | Required | - |

## Example (as JSON)

```json
{
  "surface": {
    "network": 56,
    "service": 6,
    "fs": 30,
    "api": 186
  },
  "attack": {
    "none": 94,
    "auth-failure": 232,
    "brute-force": 210,
    "exploit-vulnerability": 106,
    "social-engineer": 248
  }
}
```

